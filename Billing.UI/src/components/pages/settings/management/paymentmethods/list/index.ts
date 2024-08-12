import { Component } from "bouerjs";

import { dataContext } from "../../../../../../data/connection";
import PaymentMethod from "../../../../../../data/models/paymentMethod";
import { toDate } from "../../../../../../helpers/utils";
import PaymentMethodCreateComponent from "../create";
import html from './list.html';


export default class PaymentMethodComponent extends Component {
	readonly title = 'PaymentMethod';
	readonly route = '/paymentmethods';
	readonly children = [PaymentMethodCreateComponent];

	data = {
		active: 'paymentmethods',
		paymentmethods: new Array<PaymentMethod>(),

		toDate
	};

	constructor() {
		super(html);
	}

	loaded(evt: CustomEvent): void {
		this.data.paymentmethods = dataContext.paymentMethod.findAll();
	}
}