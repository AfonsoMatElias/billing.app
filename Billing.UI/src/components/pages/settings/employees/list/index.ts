import { Component, IComponentOptions, dynamic } from "bouerjs";

import html from './employees.html';
import CreateEmployee from "../create";
import { dataContext } from "../../../../../data/connection";
import Employee from "../../../../../data/models/employee";
import { toFullName } from "../../../../../helpers/utils";


export default class Employees extends Component {
	readonly title = 'Employees';
	readonly route = '/employees';
	readonly children = [CreateEmployee];

	data = {
		active: 'employees',
		employees: new Array<Employee>(),
		toFullName
	};

	constructor() {
		super(html);
	}

	loaded(evt: CustomEvent): void {
		this.data.employees = dataContext.employee.findAll(() => true, (e, dc) => {
			return {
				province: dc.province.findById(e.provinceId!)
			}
		});
	}
}