import { Component } from "bouerjs";

import SubCategoryCreateComponent from "../create";
import html from './list.html';
import SubCategory from "../../../../../../data/models/subCategory";
import { dataContext } from "../../../../../../data/connection";
import { toDate } from "../../../../../../helpers/utils";


export default class SubCategoryComponent extends Component {
	readonly title = 'SubCategories';
	readonly route = '/subcategories';
	readonly children = [SubCategoryCreateComponent];

	data = {
		active: 'subcategories',
		subcategories: new Array<SubCategory>(),
		
		toDate
	};

	constructor() {
		super(html);
	}

	loaded(evt: CustomEvent): void {
		this.data.subcategories = dataContext.subCategory.findAll(() => true, (row, dc) => {
			return {
				category: dc.category.findById(row.categoryId)
			}
		});
	}
}