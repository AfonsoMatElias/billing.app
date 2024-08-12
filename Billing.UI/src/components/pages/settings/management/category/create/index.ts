import { Component } from "bouerjs";

import html from './create.html';


export default class CategoryCreateComponent extends Component {
	readonly title = 'Categories';
	readonly route = '/create';

	data = {
		active: 'categories',
	};

	constructor() {
		super(html);
	}
}