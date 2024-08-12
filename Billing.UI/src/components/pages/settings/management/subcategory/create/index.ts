import { Component } from "bouerjs";

import html from './create.html';
import Category from "../../../../../../data/models/category";
import { dataContext } from "../../../../../../data/connection";


export default class SubCategoryCreateComponent extends Component {
	readonly title = 'SubCategories';
	readonly route = '/create';

	data = {
		active: 'subcategories',
		categories: new Array<Category>()
	};

	constructor() {
		super(html);
	}

	loaded(event: CustomEvent): void {
		this.data.categories = dataContext.category.findAll();
	}
}