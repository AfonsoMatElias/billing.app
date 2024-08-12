import { Component } from "bouerjs";
import html from './list.html';

const pageHeader = "List • Sells";

export default class List extends Component {
	constructor() {
		super(html);
	}
	
	readonly title = pageHeader;
	readonly route = "/list";
	readonly data = {
		search: '',
		sells: new Array<{}>(),
		navControl: {
			page: 1,
			size: 13,
			pages: 0
		},
	}

	loaded(): void {
		const bouer = this.bouer!;

		bouer.data.currentPage = pageHeader;
        bouer.$routing.markActiveAnchor(bouer.el!.querySelector('.sell-link')!);

		// this.data.providers = dataContext.provider.getAll(() => true, (c, dc) => {
		// 	return {
		// 		province: dc.province.get(c.provinceId!, (p) => {
		// 			return {
		// 				country: dc.country.get(p.countryId)
		// 			}
		// 		})
		// 	}
		// });
	}

	onSearch(str: string, input: HTMLInputElement) {
		this.data.search = str;
		return; // TODO: Request in the server
		this.bouer!.$skeleton.clear('data-loading');
	}
}