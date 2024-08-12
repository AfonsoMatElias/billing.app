import { Component } from "bouerjs";

import html from './license.html';

export default class License extends Component {
	readonly title = 'License';
	readonly route = '/license';

	data = {
		active: 'license',
	};

	constructor() {
		super(html);
	}
}