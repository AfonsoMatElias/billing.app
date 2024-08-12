import { Component } from "bouerjs";

import html from './settinggender.html';

export default class SettingGender extends Component {
    readonly name = 'setting-profile-gender'; 
	readonly data = {
        selected:'1',
	};

	constructor() {
		super(html);
	}
}