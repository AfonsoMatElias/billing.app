
import { Component } from "bouerjs";

import Create from "./create";
import List from "./list";
import View from "./view";

const pageHeader = "Provider";

export default class ProviderComponent extends Component {
	readonly name = pageHeader;
	readonly title = pageHeader;
	readonly route = "/provider";

	constructor() {
		super();
	}

	children = [
		Create,
		List,
		View
	]

	beforeLoad(event: CustomEvent): void {
		this.bouer!.$routing.navigate('/provider/list');
	}
}