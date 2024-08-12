import { Component } from "bouerjs"

import html from './table.html';
import style from './table.css';

export default class Table extends Component {
	constructor() {
		super(html, [style]);
	}
	
	readonly name = "app-table";
	readonly data: {
		onSearch?: (text: string, element: EventTarget) => void
		onNextPage?: (navControl: any) => void
		onPrevPage?: (navControl: any) => void
		search: string
		navControl?: {
			page: number
			pages: number
		}
	} = { search: '' };

	searchInput(evt: CustomEvent) {
		if (!this.data.onSearch) return;
		const target = evt.target as HTMLInputElement;
		this.data.onSearch(target!.value, target);
	};

	nextPage(evt: Event) {
		if (!this.data.onNextPage || !this.data.navControl) return;

		const page = this.data.navControl.page;
		const pages = this.data.navControl.pages;
		if (page >= pages) return;

		this.data.navControl.page++;
		this.data.onNextPage(this.data.navControl);
	};

	prevPage(evt: Event) {
		if (!this.data.onPrevPage || !this.data.navControl) return;

		const page = this.data.navControl.page;
		if (page <= 1) return;

		this.data.navControl.page--;
		this.data.onPrevPage(this.data.navControl);
	};
}