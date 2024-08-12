import { Component, dynamic } from "bouerjs";

import html from './SettingRegime.html';
import { addOrRemSpinner, hasSpinner, notify, web } from "../../../../../../../helpers/utils";
import AlertIcon from "../../../../../../../data/models/enums/alertIcon";

export default class SettingRegime extends Component {
	readonly name = 'setting-establishment-regime';
	readonly data: dynamic = {
        selected:'1',
	};

	constructor() {
		super(html);
	}

	submit(evt: Event) {
		const bouer = this.bouer!;
		const btn = evt.currentTarget as HTMLButtonElement;
		const form = btn.querySelector('[form-post]') as HTMLFormElement;

		if (hasSpinner(btn)) return;
		addOrRemSpinner(btn);

		web.call(bouer, 'estabelecimento/update-regime/' + this.data.input.id, 'put', JSON.stringify(bouer.toJsObj(form)) as any)
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

	onRegimeAdded(evt: Event) {
		// if (this.data.input.gerenteId && 
		// 	this.data.input.gerenteId == evt.$data.model.item.id)
		// 	evt.target.selected = true;
	}
}