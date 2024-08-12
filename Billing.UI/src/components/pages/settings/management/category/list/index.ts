import { Component } from "bouerjs";

import html from './list.html';
import Category from "../../../../../../data/models/category";
import { dataContext } from "../../../../../../data/connection";
import CategoryCreateComponent from "../create";


export default class CategoryComponent extends Component {
	readonly title = 'Categories';
	readonly route = '/categories';
	readonly children = [CategoryCreateComponent];

	data = {
		active: 'categories',
		categories: new Array<Category>(),
	};

	constructor() {
		super(html);
	}

	loaded(evt: CustomEvent): void {
		this.data.categories = dataContext.category.findAll();
	}
}