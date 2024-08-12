import { Component, Prop } from "bouerjs";

import html from './settingbirth.html';

export default class SettingBirth extends Component {
    readonly name = 'setting-profile-birth'; 
	readonly data = {
        // Variables
        birth:'',

        // Methods
        submit: function (evt: Event) {
            const btn = evt.currentTarget;
        }
    };

	constructor() {
		super(html);
	}
}