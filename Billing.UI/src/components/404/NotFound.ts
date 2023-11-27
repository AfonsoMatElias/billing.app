import { Component, dynamic } from "bouerjs";

import html from './NotFound.html';

export default class NotFound extends Component {
	readonly title = '404 • Page Not Found';
	readonly isNotFound = true;
	readonly route = "/notfound";

	readonly data = {
		url: location.hash ? location.hash : location.pathname
	}

	constructor() {
		super(html);
	}

	mounted(): void {
        const data = this.bouer!.data;
		data.currentPage = '🤷‍♂️ 404';
	}
}