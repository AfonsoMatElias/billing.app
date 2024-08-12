import { Component } from "bouerjs";

import html from './SettingName.html';

export default class SettingName extends Component {
	readonly name = 'setting-establishment-name';
	readonly data = {
		// Variables
		firstName: 'Loja Central',
	};

	constructor() {
		super(html);
	}
}