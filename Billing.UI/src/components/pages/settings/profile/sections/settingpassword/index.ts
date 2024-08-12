import { Component } from "bouerjs";

import html from './settingpassword.html';

export default class SettingPassword extends Component {
    readonly name = 'setting-profile-password'; 
	constructor() {
		super(html);
	}
}