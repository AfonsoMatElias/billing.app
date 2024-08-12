import { Component, dynamic } from "bouerjs";

import html from './view.html';

const pageHeader = "Product • View";

export default class View extends Component {
	readonly title = pageHeader;
	readonly route = "/view/{id}";

	readonly data = {
	}

	constructor() {
		super(html);
	}

	mounted(): void {
        const data = this.bouer!.data;
		data.currentPage = pageHeader;
	}
}