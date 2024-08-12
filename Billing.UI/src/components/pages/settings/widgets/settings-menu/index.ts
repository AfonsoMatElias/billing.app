import { Component } from "bouerjs";

import html from './settingsmenu.html';

export default class SettingsMenu extends Component {
	readonly name = 'settings-menu';

	data = {
		active: '',
		list: [
			{
				text: 'Profile',
				name: 'profile',
				url: '/settings/profile'
			},
			{
				text: 'Funcionários',
				name: 'employees',
				url: '/settings/employees'
			},
			{
				text: 'Dados de Referência',
				name: 'management',
				url: '/settings/management'
			},
			{
				text: 'Lojas',
				name: 'stores',
				url: '/settings/stores'
			},
			{
				text: 'Preferências',
				name: 'preferences',
				url: '/settings/preferences'
			},
			{
				text: 'Licença',
				name: 'license',
				url: '/settings/license'
			},
			{
				text: 'Acerca',
				name: 'about',
				url: '/settings/about'
			},
		]
	}

	constructor() {
		super(html);
	}

	loaded(evt: CustomEvent): void {
		const bouer = this.bouer!;
		bouer.data.currentPage = 'Settings';
		
		setTimeout(() =>
			bouer.$routing.markActiveAnchor(
				bouer.el!.querySelector('.settings-link')!), 
		1);
	}
}