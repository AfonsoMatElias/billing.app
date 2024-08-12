import { Component } from "bouerjs";

import Create from "./create";
import View from "./view";

import html from './store.html';
import Store from "../../../../data/models/store";
import { dataContext } from "../../../../data/connection";

export default class StoreComponent extends Component {
	readonly title = 'Stores';
	readonly route = '/stores';
	readonly children = [
		Create,
		View
	];

	data = {
		active: 'stores',
		stores: new Array<Store>(),
	};

	constructor() {
		super(html);
	}

	loaded(event: CustomEvent): void {
		this.data.stores = dataContext.store.findAll(() => true, (s, dc) => {
			return {
				manager: dc.employee.findById(s.managerId!),
				province: dc.province.findById(s.provinceId, (p) => {
					return {
						country: dc.country.findById(p.countryId)
					}
				})
			};
		})
	}
}