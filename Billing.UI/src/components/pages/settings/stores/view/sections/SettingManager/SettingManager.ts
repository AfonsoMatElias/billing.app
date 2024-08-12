import { Component, dynamic } from "bouerjs";

import html from './SettingManager.html';
import AlertIcon from "../../../../../../../data/models/enums/alertIcon";
import { hasSpinner, addOrRemSpinner, web, notify } from "../../../../../../../helpers/utils";

export default class SettingManager extends Component {
	readonly name = 'setting-establishment-manager';
	readonly data: dynamic = {
		// Variables
		selected: '1',

	};

	constructor() {
		super(html);
	}

	// Methods
	submit(evt: Event) {
		const bouer = this.bouer!;
		const btn = evt.currentTarget as HTMLButtonElement;
		const form = btn.querySelector('[form-post]') as HTMLFormElement;

		if (hasSpinner(btn)) return;
		addOrRemSpinner(btn);

		web.call(bouer, 'estabelecimento/update-manager/' + this.data.input.id, 'put', JSON.stringify(bouer.toJsObj(form)) as any)
			.then(function () {
				notify.call(bouer, {
					type: AlertIcon.success,
					message: 'Registro Actualizado',
					run: function () {
						location.reload();
					}
				});
			})
			.finally(() => {
				addOrRemSpinner(btn, true);
			});
	};

	onFuncionarioAdded(evt: Event) {
		// if (this.data.input.gerenteId &&
		// 	this.data.input.gerenteId == evt.$data.model.item.id)
		// 	evt.target.selected = true;
	};
}