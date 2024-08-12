import { Component } from "bouerjs";
import html from './list.html';
import { dataContext } from "../../../../data/connection";
import Stock from "../../../../data/models/stock";

const pageHeader = "List • Active Stock";

export default class List extends Component {
	constructor() {
		super(html);
	}
	
	readonly title = pageHeader;
	readonly route = "/list";
	readonly data = {
		search: '',
		stocks: new Array<Stock>(),
		navControl: {
			page: 1,
			size: 13,
			pages: 0
		},
	}

	loaded(): void {
		const bouer = this.bouer!;

		bouer.data.currentPage = pageHeader;
        bouer.$routing.markActiveAnchor(bouer.el!.querySelector('.buy-link')!);

		this.data.stocks = dataContext.stock.findAll((item) => item.isActive, (c, dc) => {
			return {
				provider: dc.provider.findById(c.providerId!),
				product: dc.product.findById(c.productId!)
			}
		});
	}

	onSearch(str: string, input: HTMLInputElement) {
		this.data.search = str;
		return; // TODO: Request in the server
		this.bouer!.$skeleton.clear('data-loading');
	}
}