import { Component } from "bouerjs";

import html from './settingname.html';

export default class SettingName extends Component {
    readonly name = 'setting-profile-name';
	readonly data = {
        // Variables
        firstName:'Afonso',
        lastName:'Matumona',

        // Methods
        submit: function (evt: Event) {
            var btn = evt.currentTarget;
        }
    };
	constructor() {
		super(html);
	}
}