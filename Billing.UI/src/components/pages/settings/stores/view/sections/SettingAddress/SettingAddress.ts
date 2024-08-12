import { Component } from "bouerjs";

import html from './SettingAddress.html';

export default class SettingAddress extends Component {
	readonly name = 'setting-establishment-address';
	readonly data = {
		// Variables
		firstName: 'Loja Central',
	};

	constructor() {
		super(html);
	}
}