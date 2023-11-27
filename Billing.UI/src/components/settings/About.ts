import { Component } from "bouerjs";
const { Chart } = require("@canvasjs/charts");

import html from './About.html';

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