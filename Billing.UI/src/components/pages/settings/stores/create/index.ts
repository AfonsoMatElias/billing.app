import { Component } from "bouerjs";

import html from './create.html';
import { aboveMe, addOrRemSpinner, hasSpinner, notify, web } from "../../../../../helpers/utils";
import AlertIcon from "../../../../../data/models/enums/alertIcon";

export default class Create extends Component {
	readonly title = 'Create Store';
	readonly route = '/create';

	data = {
		active: 'store',
	};

	constructor() {
		super(html);
	}

	submit(evt: Event) {
		const bouer = this.bouer!
		const btn = evt.currentTarget as HTMLButtonElement;
		const form = aboveMe(btn, 'form') as HTMLFormElement;

		if (hasSpinner(btn)) return;
		addOrRemSpinner(btn);

		web.call(bouer, 'estabelecimento', 'post', JSON.stringify(bouer.toJsObj(form)))
			.then(function () {
				notify.call(bouer, {
					type: AlertIcon.success,
					message: 'Registro Criado',
					run: function () {
						bouer.$routing.navigate("/settings/apps");
					}
				});
			})
			.finally(function () {
				addOrRemSpinner(btn, true);
			});
	}
}