import { Component } from "bouerjs";

import html from './management-menu.html';

export default class ManagementMenu extends Component {
	readonly name = 'management-menu';

	data = {
		active: '',
		list: [
            {
                name: 'country',
                url: '/settings/management/countries',
                text: 'Países'
            },
            {
                name: 'categories',
                url: '/settings/management/categories',
                text: 'Categorias'
            },
            {
                name: 'subcategories',
                url: '/settings/management/subcategories',
                text: 'SubCategorias'
            },
            {
                name: 'paymentmethods',
                url: '/settings/management/paymentmethods',
                text: 'Formas de Pagamento'
            },
        ],
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