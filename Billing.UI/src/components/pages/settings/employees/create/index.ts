import { Component } from "bouerjs";

import { aboveMe, addOrRemSpinner, hasSpinner, notify, toCode } from "../../../../../helpers/utils";
import html from './create.html';
import Gender from "../../../../../data/models/enums/gender";
import UserRole from "../../../../../data/models/enums/userRole";
import Store from "../../../../../data/models/store";
import { dataContext } from "../../../../../data/connection";

export default class CreateEmployee extends Component {
	readonly title = 'Create Employee';
	readonly route = '/create';

	data = {
		active: 'employees',
		roles: new Array<{ id: string, name: string }>(),
		genders: new Array<{ id: string, name: string }>(),
		stores: new Array<Store>(),

		toCode
	};

	constructor() {
		super(html);
	}

	loaded(event: CustomEvent) {
		this.data.stores = dataContext.store.findAll();
		this.data.genders = Object.keys(Gender).map((k: any) => {
			return {
				id: k,
				name: (Gender as any)[k]
			}
		});
		this.data.roles = Object.keys(UserRole).map((k: any) => {
			return {
				id: k,
				name: (UserRole as any)[k]
			}
		});
	}

	onRoleAdded(evt: CustomEvent) {



	}

	submit(evt: CustomEvent) {
		const bouer = this.bouer!;
		const btn = evt.currentTarget as Element;
		const form = aboveMe(btn, 'form');

		if (hasSpinner(btn)) return;
		addOrRemSpinner(btn);

		const obj = bouer.toJsObj(form as HTMLElement);

		console.log(obj);

		return;
		notify.call(bouer, {
			type: 'success',
			message: 'Registro Criado',
			run: function () {
				bouer.$routing.navigate("/settings/employees");
			}
		});
	}
}