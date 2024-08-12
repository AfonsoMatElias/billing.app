import { Component } from "bouerjs";

import { dataContext } from "../../../../data/connection";
import Customer from "../../../../data/models/customer";
import html from './list.html';

const pageHeader = "List • Customer";

export default class List extends Component {
	readonly title = pageHeader;
	readonly route = "/list";
	readonly data = {
		search: '',
		customers: new Array<Customer>(),
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
        bouer.$routing.markActiveAnchor(bouer.el!.querySelector('.customer-link')!);

		this.data.customers = dataContext.customer.findAll(() => true, (c, dc) => {
			return {
				province: dc.province.findById(c.provinceId!, (p) => {
					return {
						country: dc.country.findById(p.countryId)
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
}