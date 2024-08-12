import { Component } from "bouerjs";

import html from './settingphoto.html';

export default class SettingPhoto extends Component {
    readonly name = 'setting-profile-photo'; 
	readonly data = {
		url: ''
	};

	constructor() {
		super(html);
	}
}