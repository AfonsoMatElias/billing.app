import { Component, Watch } from "bouerjs";

import { dataContext } from "../../../../data/connection";
import AlertIcon from "../../../../data/models/enums/alertIcon";
import Product from "../../../../data/models/product";
import Stock from "../../../../data/models/stock";
import User from "../../../../data/models/user";
import { addOrRemSpinner, hasSpinner, notify, toNullType as toNull, toProductImage } from "../../../../helpers/utils";
import html from './add.html';
import Provider from "../../../../data/models/provider";
import UserModel from "../../../../data/models/view/userModel";

const pageHeader = "Add Stock";

function toFixed(n: number) {
	return Number.parseInt((n || 0).toFixed(2));
}

const customer = {
	id: '',
	name: 'Cliente Não Selecionado',
	idCard: 'Clique em `?` para Selecionar'
};

type StockItem = {
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

export default class Create extends Component {
	constructor() {
		super(html);
	}

	readonly title = pageHeader;
	readonly route = "/add";

	readonly watches: Watch<any, any>[] = [];
	selectedProductElement = toNull<Element>()

	readonly data = {
		findProduct: '',
		stocks: new Array<Stock>(),
		products: new Array<Product>(),
		providers: new Array<Provider>(),
		selectedProduct: {
			id: '',
			name: '',
		},

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
		this.bouer!.$routing.markActiveAnchor(bouer.el!.querySelector('.buy-link')!);

		this.data.providers = dataContext.provider.findAll();
		this.data.products = dataContext.product.findAll(() => true, (row, dc) => {
			return {
				stocks: dc.stock.findAll(x => x.productId == row.id && x.isActive)
			}
		});
	}


	clearForm(form: HTMLElement) {
		const elements: Element[] = form.querySelectorAll('[name]') as any;

		// Unmarking the old selected product
		if (this.selectedProductElement)
			this.selectedProductElement
				.querySelector('.fa')!.classList.remove('fa-check');

		for (var element of elements) {
			switch (element.tagName) {
				case 'B':
					this.data.selectedProduct.id = '';
					this.data.selectedProduct.name = 'Seleccione um produto';
					break;
				case 'SELECT':
					(element as HTMLSelectElement).selectedIndex = 0;
					break;
				default:
					(element as any).value = '';
					break;
			}
		}
	}

	submit(evt: CustomEvent) {
		const btn = evt.currentTarget as Element;
		const form = this.data.stocks;
		const bouer = this.bouer!;

		if (form.length === 0)
			return notify.call(bouer, {
				type: 'warn',
				message: 'Lista de Compras Vazia!'
			});

		if (hasSpinner(btn)) return;
		addOrRemSpinner(btn);

		// web('compra/massive', 'post', JSON.stringify(form))
		// 	.then(function (data) {
		// 		notify({
		// 			type: 'success',
		// 			message: 'Registro Efectuado',
		// 			run: function () {
		// 				component.data.buyList = [];
		// 			}
		// 		});

		// 		var productList = bouer.$req.get('product-list');
		// 		for (const item of productList.data) {
		// 			form.find(function (formItem) {
		// 				if ((item.id * 1) === (formItem.ProdutoId * 1)) {
		// 					if (item.compras.length === 0)
		// 						item.compras = [{ quantidade: formItem.Quantidade }];
		// 					else
		// 						item.compras[0].quantidade += formItem.Quantidade * 1;

		// 					item.precoUnitario = formItem.PrecoUnitarioVenda * 1;
		// 				}
		// 			})
		// 		}
		// 	})
		// 	.finally(function () {
		// 		addOrRemSpinner(btn, true);
		// 	})
	}

	chooseProduct(el: Element, product: Product) {
		// Applying the select value in the input area
		this.data.selectedProduct.id = product.id;
		this.data.selectedProduct.name = product.name;

		// Unmarking the old selected product
		if (this.selectedProductElement)
			this.selectedProductElement.querySelector('.fa')!
				.classList.remove('fa-check');

		// Marking the selected product
		el.querySelector('.fa')!.classList.add('fa-check');
		this.selectedProductElement = el;
	}

	addBuyItem(form: HTMLElement) {
		const bouer = this.bouer!;
		const user = bouer.globalData.user as UserModel;

		if (!user.employee)
			return notify.call(bouer, {
				type: AlertIcon.error,
				message: 'This user cannot perfome this operation'
			});

		if (form.querySelector('[field-value="0"]'))
			return notify.call(bouer, {
				type: 'warn',
				message: 'Selecione um produto!'
			});

		// Generating the objcet
		const obj = bouer.toJsObj(form, {
			values: '[field-value],[value]'
		}) as Stock;

		const selected = (form.querySelector('[name="FornecedorId"]') as any).selectedOptions![0].text;

		// // Adding some id
		// obj.$id = toCode(5);
		// obj.row = {
		// 	Provider: selected !== 'None' ? selected : 'N/A',
		// 	Product: form.querySelector('[name="ProdutoId"]').textContent
		// };

		obj.storeId = user.employee!.storeId;

		// Addintg to the list
		this.data.stocks.push(obj);

		// Clearing the form
		this.clearForm(form);
	}

	removeBuyItem(stockItem: Stock) {
		const buyList = this.data.stocks;
		buyList.splice(buyList.indexOf(stockItem), 1);
	}

	cancelBuy(form: HTMLElement) {
		this.clearForm(form);
		// Clearing the list
		this.data.stocks = [];
	}

	markActive(el: HTMLElement, product: Product) {
		if (this.data.selectedProduct.id == product.id) {
			el.querySelector('.fa')!.classList.add('fa-check');
			this.selectedProductElement = el;
		}

		if (product.code == this.params().p)
			this.chooseProduct(el, product);
	}

	destroyed(event: CustomEvent): void {
		// Destroying all watches
		for (const watch of this.watches)
			watch.destroy();
	}
}