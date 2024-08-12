import { Component } from "bouerjs";

import html from './preferences.html';

export default class Preferences extends Component {
	readonly title = 'Preferences';
	readonly route = '/preferences';

	data = {
		active: 'preferences',
		preferences: []
	};

	constructor() {
		super(html);
	}

	loaded(event: CustomEvent): void {
		const bouer = this.bouer!;
		this.data.preferences = bouer.globalData.preferences || [];
	}
}