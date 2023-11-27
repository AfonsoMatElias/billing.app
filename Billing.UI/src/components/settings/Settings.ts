import { Component } from "bouerjs";
import { aboveMe, notify } from "../../helpers/utils";
import html from './settings.html';


export default class Settings extends Component {
	readonly title = 'Settings';
	readonly route = '/settings';

	data = {
		aboveMe
	};

	constructor() {
		super(html);
	}

	loaded(): void {
		const bouer = this.bouer!;
		bouer!.data.currentPage = 'Configurações';

		setTimeout(function () {
			bouer.$routing.markActiveAnchor(bouer.el!.querySelector('.settings-link') as HTMLAnchorElement);
		}, 100);

		bouer.$wait.set('setting-methods', {
			loadSectionShared: (loadableComponents: any, name: string, data: any) => {
				// Checking if the name is ok
				if (!name) return;

				// Getting the container
				const container = this.el!.querySelector('#loadable');

				// Checking if the container is ok
				if (!container) return;

				// Checking if the component is valid
				if (!loadableComponents[name]) {
					return notify.call(bouer, {
						message: 'Secção Inexistente ou em criação.',
						type: 'warn'
					});
				}

				// Clearing the container
				container.innerHTML = '';

				// Creating the INC element
				const component = document.createElement(name);

				if (!this.el!.querySelector('.setting-panel-closer')) {
					var content = '<span title="Fechar Painel" class="reduced-screen-button center-icon fa fa-remove setting-panel-closer"' +
						'onclick="event.target.previousElementSibling.classList.remove(\'show-right-zero\')"></span>';
					var _div = document.createElement('div');
					_div.innerHTML = content;

					aboveMe(container)!.appendChild(_div.children[0]);
				}

				if (!container.classList.contains('show-right-zero'))
					container.classList.add('show-right-zero');

				component.setAttribute('data', '$data');

				// Adding in the container
				container.appendChild(component);

				bouer.compile({
					el: component,
					data: data || {},
					context: this
				})
			}
		})
	}
}