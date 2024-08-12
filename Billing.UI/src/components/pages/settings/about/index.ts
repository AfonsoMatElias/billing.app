import { Component } from "bouerjs";
import html from './about.html';

export default class About extends Component {
	readonly title = 'About';
	readonly route = '/about';

	data = {
		active: 'about',
		name: 'Billing App',
		desc: 'Aplicação de Gestão de Stock de Produtos',
		version: 'v1.0.0',
		madeBy: '@AfonsoMatElias'
	};

	constructor() {
		super(html);
	}
}