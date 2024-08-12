import { Component, Watch } from "bouerjs";

import { dataContext } from "../../../../data/connection";
import Stock from "../../../../data/models/stock";
import { notify, toNullType as toNull, toObject, toProductImage } from "../../../../helpers/utils";
import html from './view.html';

const pageHeader = "View Active Stock";

function toFixed(n: number) {
	return Number.parseInt((n || 0).toFixed(2));
}

const customer = {
	id: '',
	name: 'Cliente Não Selecionado',
	idCard: 'Clique em `?` para Selecionar'
};

export default class View extends Component {
	constructor() {
		super(html);
	}

	readonly title = pageHeader;
	readonly route = "/view/{id}";
	readonly watches: Watch<any, any>[] = [];
	selectedProductElement = toNull<Element>()

	readonly data = {
		findProduct: '',
		stocks: new Array<Stock>(),
		stock: toObject<Stock>(),
		toProductImage
	};


	mounted(): void {
		const data = this.bouer!.data;
		data.currentPage = pageHeader;
	}

	loaded(evt: CustomEvent) {
		const el = evt.target as Element;
		const bouer = this.bouer!;

		// Marking the menu
		bouer.$routing.markActiveAnchor(bouer.el!.querySelector('.buy-link')!);
		const stockId = this.params().id;

		const stock = this.data.stock = dataContext.stock.findById(stockId, (c, dc) => {
			return {
				provider: dc.provider.findById(c.providerId!),
				product: dc.product.findById(c.productId!)
			}
		})!;

		if (!stock) {
			return setTimeout(() => {
				notify.call(bouer, {
					message: 'Stock com identificador `'+ stockId +'` não encontrado.',
					run() {
						window.history.back();
						// bouer.$routing.navigate('/stock/list');
					},
				});
			}, 3000);
		}

		this.data.stocks = dataContext.stock.findAll((item) => item.productId == stock.productId, (c, dc) => {
			return {
				provider: dc.provider.findById(c.providerId!),
				product: dc.product.findById(c.productId!)
			}
		});
	}
}