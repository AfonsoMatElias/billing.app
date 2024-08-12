import { Component } from "bouerjs";

import html from './profile.html';
import SettingPhoto from "./sections/settingphoto";
import SettingName from "./sections/settingname";
import SettingBirth from "./sections/settingbirth";
import SettingGender from "./sections/settinggender";
import SettingPassword from "./sections/settingpassword";

export default class Profile extends Component {
	constructor() {
		super(html);
	}

	readonly title = 'Profile';
	readonly route = '/profile';

	readonly data = {
		active: 'profile',
		currentSection: '',
		loggedUser: {
			id: '1001',
			userName: 'AfonsoMatElias',
			email: 'Afonsomatumona@hotmail.com',
			nome: 'Afonso Matumona',
			user: {
				genero: 'Masculino',
				dataNascimento: '1996-01-13T12:12:56:213Z'
			},
		}
	};

	readonly children = [
		SettingPhoto,
		SettingName,
		SettingBirth,
		SettingGender,
		SettingPassword
	];
}