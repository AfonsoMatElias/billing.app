import { Component, dynamic, Watch } from "bouerjs";

import { dataContext } from "../../../data/connection";
import Customer from "../../../data/models/customer";
import Product from "../../../data/models/product";
import { notify, toCode, toProductImage } from "../../../helpers/utils";
import List from "./list";
import html from './sell.html';

const pageHeader = "Sell Product";

function toFixed(n: number) {
	return Number.parseInt((n || 0).toFixed(2));
}

const customer = {
	id: '',
	name: 'Cliente Não Selecionado',
	idCard: 'Clique em `?` para Selecionar'
};

type Busket = {
	id: string,
	productId: string,
	name: string,
	price: number,
	stock: number,
	subtotal: number,
	descount: number,
	qty: number,
	iva: number
}

const empty: any = '0';

export default class SellComponent extends Component {
	constructor() {
		super(html);
	}

	readonly title = pageHeader;
	readonly route = "/sell";
	readonly children = [List];
	readonly watches: Watch<any, any>[] = [];

	readonly data = {
		busketProducts: new Array<Busket>(),
		products: new Array<Product>(),
		customers: new Array<Customer>(),
		showCustomerSelection: false,
		findCustomer: '', 
		paymentWays: [],
		touchpad: {
			value: empty,
			buttons:
				[
					1, 2, 3,
					4, 5, 6,
					7, 8, 9,
					'C', '0', '⇐'
				]
		},
		reference: '',
		sellingResume: {
			subtotal: 0,
			descount: 0,
			exchange: 0,
			total: 0,
			paid: 0
		},
		customer: {
			id: '',
			photo: '',
			name: customer.name,
			idCard: customer.idCard
		},
		formaPagamentoId: '',

		toProductImage
	};


	mounted(): void {
		const data = this.bouer!.data;
		data.currentPage = pageHeader;
	}

	loaded(evt: CustomEvent): void {
		const el = evt.target as Element;
		const bouer = this.bouer!;
		// Marking the menu
		this.bouer!.$routing.markActiveAnchor(bouer.el!.querySelector('.sell-link')!);

		this.data.customers = dataContext.customer.findAll();
		this.data.products = dataContext.product.findAll(() => true, (row, dc) => {
			return {
				stocks: dc.stock.findAll(x => x.productId == row.id && x.isActive)
			}
		});
	}

	calculateResume() {
		let subtotal = 0;
		let descount = 0;
		// Shortcut
		const resume = this.data.sellingResume;
		this.data.busketProducts.filter(function (b, acc) {
			const _iva = ((b.price * b.qty) * (b.iva || 0 / 100));
			const _descount = ((b.price * b.qty) * (b.descount / 100));
			const _subtotal = ((b.price * b.qty) - _descount + _iva);

			b.subtotal = toFixed(_subtotal);
			descount += (_descount);
			subtotal += (_subtotal);
		});

		resume.subtotal = toFixed(subtotal);
		resume.descount = toFixed(descount);
		resume.total = toFixed(subtotal);
		resume.exchange = toFixed(resume.paid - resume.total);
	}

	calcButtonClick(evt: CustomEvent) {
		const value = (evt.currentTarget as Element)!.getAttribute('val')!;
		const data = this.data.sellingResume;
		const touchpad = this.data.touchpad;
		switch (value) {
			case 'C': // Clear everything
				touchpad.value = data.paid = 0;

				break;
			case '⇐': // Remove the last digit
				if (touchpad.value.length === 1)
					touchpad.value = data.paid = 0;
				else {
					var $value = touchpad.value;
					touchpad.value = $value.substring(0, $value.length - 1);
					data.paid = touchpad.value * 1;
				}
				break;
			default: // Default add
				if (touchpad.value === '0')
					touchpad.value = data.paid = Number.parseInt(value);
				else {
					touchpad.value += value;
					data.paid = touchpad.value * 1;
				}
				break;
		}
	}
	addProductToBusket(product: Product) {
		const bouer = this.bouer!;
		const onBusket = this.data.busketProducts.find(x => x.productId == product.id);

		if (onBusket) return onBusket.qty++;

		if (product.stocks[0] == null || (product.stocks[0].quantity == 0 && product.isStock)) {
			return;
		}

		const activeStock = product.stocks[0];

		// Creating the buckect object
		const busketProduct: Busket = {
			id: toCode(),
			productId: product.id,
			name: product.name,
			price: product.price,
			stock: (product.stocks[0] || {}).quantity || 0,
			subtotal: product.price,
			iva: product.iva || 0,
			descount: 0,
			qty: 1,
		};

		// Adding to the UI
		this.data.busketProducts.push(busketProduct);

		// Updating the resume fields
		this.calculateResume();

		// Decreasing the stock value
		activeStock.quantity--;

		// Watching qty property
		const $wQty = bouer.watch("qty", (qty, oldQuantity) => {
			// Shortcut
			const b = busketProduct;
			const newStock = b.stock - qty;

			if (newStock < 0) {
				busketProduct.qty = b.stock;
				return notify.call(bouer, {
					type: 'warn',
					message: 'Stock insuficiente'
				});
			}

			activeStock.quantity = newStock;
			// b.subtotal = (b.price * qty) - (b.price * (b.descount / 100));
			// Updating the resume fields
			this.calculateResume();
		}, busketProduct)!;

		// Watching descount property
		const $wDescount = bouer.watch("descount", (descount) => {
			// // Shortcut
			// var b = busketProduct;
			// b.subtotal = (b.price * b.qty) - (b.price * (descount / 100));
			// Updating the resume fields
			this.calculateResume();
		}, busketProduct)!;

		// Watching paid property
		const $wPaid = bouer.watch("paid", (paid) => {
			this.data.sellingResume.exchange = toFixed(paid - this.data.sellingResume.total);
		}, this.data.sellingResume)!;

		this.watches.push($wQty, $wDescount, $wPaid);

		// Addind the remove event emitter 
		bouer.on('remove:' + busketProduct.id, function () {
			$wQty.destroy();
			$wPaid.destroy();
			$wDescount.destroy();
		});
	}
	removeProductFromBusket(busket: Busket) {
		// Removing from the list
		const bouer = this.bouer!;
		const index = this.data.busketProducts.indexOf(busket);

		this.data.busketProducts.splice(index, 1);

		// Updating quantity
		// It will reset the old value of the product
		busket.qty = 0;

		// Destroying the busket watch
		bouer.emit('remove:' + busket.id, { once: true });
	}

	cancelSell() {
		while (this.data.busketProducts.length != 0)
			this.removeProductFromBusket(this.data.busketProducts[0]);

		const sellingResume = this.data.sellingResume as dynamic;

		const keys = Object.keys(sellingResume);

		for (const k of keys)
			sellingResume[k] = 0;

		this.data.customer.photo = '';
		this.data.customer.id = customer.id;
		this.data.customer.name = customer.name;
		this.data.customer.idCard = customer.idCard;
	}
	handleCustomerSelection(evt: CustomEvent) {
		if (!this.data.customer.id)
			return this.data.showCustomerSelection = true;

		this.data.customer.photo = '';
		this.data.customer.id = customer.id;
		this.data.customer.name = customer.name;
		this.data.customer.idCard = customer.idCard;
	}
	handleCustomerItemClick(item: dynamic) {
		this.data.customer.id = item.id;
		this.data.customer.name = item.name;
		this.data.customer.idCard = item.idCard;
		this.data.showCustomerSelection = false;
	}

	submit(evt: CustomEvent, tipoVenda: dynamic, tipoFactura: dynamic) {
		const btn = evt.currentTarget as HTMLButtonElement;

		if (this.data.busketProducts.length === 0)
			return notify.call(this.bouer!, {
				type: 'warn',
				message: 'Carrinho Vazio!'
			});

		if (!this.data.formaPagamentoId)
			return notify.call(this.bouer!, {
				type: 'warn',
				message: 'Selecione a Forma de Pagamento!'
			});

		// if (hasSpinner(btn)) return;
		// 	addOrRemSpinner(btn);

		// var form = {
		// 	CodigoTipoVenda: tipoVenda,
		// 	FormaPagamentoId: this.data.formaPagamentoId,
		// 	ClienteId: this.data.customer.id || undefined,
		// 	Total: this.data.sellingResume.total,
		// 	Factura: {
		// 		CodigoTipoFactura: tipoFactura
		// 	},
		// 	VendaItens: this.data.busketProducts
		// 		.map(function (item) {
		// 			return {
		// 				ProdutoId: item.id,
		// 				Quantidade: item.qty,
		// 				Preco: item.price,
		// 				Desconto: item.descount
		// 			};
		// 		})
		// }

		// web('venda', 'post', JSON.stringify(form))
		// 	.then(function (data) {
		// 		notify({
		// 			type: 'success',
		// 			message: 'Operação Efectuada!'
		// 		});

		// 		component.data.busketProducts = [];
		// 		component.data.formaPagamentoId = '';
		// 		component.el.querySelector('#reset').click();
		// 	})
		// 	.finally(function () {
		// 		addOrRemSpinner(btn, true);
		// 	})
	}

	destroyed(event: CustomEvent): void {
		// Destroying all watches
		for (const watch of this.watches)
			watch.destroy();
	}
}