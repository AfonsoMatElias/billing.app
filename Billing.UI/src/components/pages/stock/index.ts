
import { Component } from "bouerjs";

import Add from "./add";
import List from "./list";
import View from "./view";

const pageHeader = "Stock";

export default class StockComponent extends Component {
	readonly name = pageHeader;
	readonly title = pageHeader;
	readonly route = "/stock";

	constructor() {
		super();
	}

	children = [
		Add,
		List,
		View
	]

	mounted(evt: CustomEvent): void {
		this.bouer!.$routing.navigate('/stock/add');
	}
}