
import { Component } from "bouerjs";

import Create from "./create";
import List from "./list";
import View from "./view";

const pageHeader = "Product";

export default class ProductComponent extends Component {
	readonly title = pageHeader;
	readonly route = "/product";
	readonly componentId = 'abc';

	constructor() {
		super();
	}

	children = [
		Create,
		List,
		View
	];

	beforeLoad(event: CustomEvent): void {
		this.bouer!.$routing.navigate('/product/list');
	}
}