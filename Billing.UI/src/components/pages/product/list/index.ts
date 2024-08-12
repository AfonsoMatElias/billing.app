import { Component, dynamic } from "bouerjs";

import html from './list.html';
import Product from "../../../../data/models/product";
import { dataContext } from "../../../../data/connection";

const pageHeader = "Product • List";

export default class List extends Component {
	readonly title = pageHeader;
	readonly route = "/list";

	readonly data = {
		search: '',
		products: new Array<Product>(),
		navControl: {
			page: 1,
			size: 13,
			pages: 0
		},
	}

	constructor() {
		super(html);
	}

	loaded(): void {
		const bouer = this.bouer!;

		bouer.data.currentPage = pageHeader;
        bouer.$routing.markActiveAnchor(bouer.el!.querySelector('.product-link')!);

		this.data.products = dataContext.product.findAll(() => true, (product, dc) => {
			return {
				subCategory: dc.subCategory.findById(product.subCategoryId, (subCategory) => {
					return {
						category: dc.category.findById(subCategory.categoryId)
					}
				})
			}
		});
	}

	onSearch(str: string, input: HTMLInputElement) {
		this.data.search = str;
		return; // TODO: Request in the server
		this.bouer!.$skeleton.clear('data-loading');
	}
	onNextPage(control: any) {
		this.data.navControl = control;
	}
	onPrevPage(control: any) {
		this.data.navControl = control;
	}
	onRequest(evt: CustomEvent) {
		// if (searcher) searcher.classList.add('loading-input');
	}
	onResponse(evt: CustomEvent) {
		// if (searcher) searcher.classList.add('loading-input');
		var response = evt.detail.response;
		this.data.navControl.pages = response.pagination.totalPages;
	}
}