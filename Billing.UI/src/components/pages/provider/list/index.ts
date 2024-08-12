import { Component } from "bouerjs";

import { dataContext } from "../../../../data/connection";
import Provider from "../../../../data/models/provider";
import html from './list.html';

const pageHeader = "List • Provider";

export default class List extends Component {
	constructor() {
		super(html);
	}
	
	readonly title = pageHeader;
	readonly route = "/list";
	readonly data = {
		search: '',
		providers: new Array<Provider>(),
		navControl: {
			page: 1,
			size: 13,
			pages: 0
		},
	}

	loaded(): void {
		const bouer = this.bouer!;

		bouer.data.currentPage = pageHeader;
        bouer.$routing.markActiveAnchor(bouer.el!.querySelector('.provider-link')!);

		this.data.providers = dataContext.provider.findAll(() => true, (c, dc) => {
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