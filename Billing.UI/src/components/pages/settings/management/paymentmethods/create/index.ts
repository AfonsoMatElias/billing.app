import { Component } from "bouerjs";

import html from './create.html';


export default class PaymentMethodCreateComponent extends Component {
	readonly title = 'Payment Method';
	readonly route = '/create';

	data = {
		active: 'paymentmethods',
	};

	constructor() {
		super(html);
	}
}