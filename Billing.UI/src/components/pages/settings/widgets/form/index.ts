import { Component, forEach } from "bouerjs";

import html from './form.html';
import { toObject } from "../../../../../helpers/utils";

export default class FormDynamic extends Component {
	readonly name = 'form-dynamic';

	data = {
		active: '',
		inputs: [],
		source: toObject<any>(),
	}

	constructor() {
		super(html);
	}

	onOptionAdded(evt: CustomEvent) {
		
	}
}