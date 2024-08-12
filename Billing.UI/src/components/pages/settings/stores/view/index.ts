import { Component, dynamic, Reactive } from "bouerjs";

import html from './view.html';
import { toObject } from "../../../../../helpers/utils";
import Store from "../../../../../data/models/store";
import { dataContext } from "../../../../../data/connection";

export default class View extends Component {
	readonly title = 'Store';
	readonly route = '/view/{id}';

	readonly data = {
		active: 'store',
		isLoading: true,
		section: new Array<any>(),
		store: toObject<Store>(),
	};

	newProp = 'afonso matumona';

	constructor() {
		super(html);
	}

	loaded(evt: Event) {
		const storeId = this.params().id;

		this.data.store = dataContext.store.findById(storeId, (s, dc) => {
			return {
				manager: dc.employee.findById(s.managerId!),
				province: dc.province.findById(s.provinceId, (p) => {
					return {
						country: dc.country.findById(p.countryId)
					}
				})
			};
		});
	}

	onSectionClick(key: string) {
		const sections: any = {
			name: {
				headerName: 'Nome',
				headerInfo: 'Altere o nome da Loja',
				inputs: [{
					type: 'text',
					name: 'Nome',
					field: 'name'
				}],
				source: this.data.store
			},
			nif: {
				headerName: 'Nif',
				headerInfo: 'Altere o nif do estabelecimento',
				inputs: [{
					type: 'text',
					name: 'Nif',
					field: 'nif'
				}],
				source: this.data.store
			},
			address: {
				headerName: 'Endereço',
				headerInfo: 'Altere o endereço do estabelecimento',
				inputs: [
					{
						type: 'select',
						name: 'Pais',
						field: 'n_a',
						data: dataContext.country.findAll()
					},
					{
						type: 'select',
						name: 'Provincia',
						field: 'provinceId',
						data: dataContext.province.findAll()
					},
					{
						type: 'textarea',
						name: 'Endereço detalhado',
						field: 'address',
					},
				],
				source: this.data.store
			}
		};

		const value = sections[key];

		if (!value) return;

		this.data.section = [value];
	}
}