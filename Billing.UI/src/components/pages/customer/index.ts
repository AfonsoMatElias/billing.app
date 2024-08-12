
import { Component } from "bouerjs";

import Create from "./create";
import List from "./list";
import View from "./view";

const pageHeader = "Customer";

export default class CustomerComponent extends Component {
	readonly name = pageHeader;
	readonly title = pageHeader;
	readonly route = "/customer";

	constructor() {
		super();
	}

	children = [
		Create,
		List,
		View
	]

	beforeLoad(event: CustomEvent): void {
		this.bouer!.$routing.navigate('/customer/list');
	}
}