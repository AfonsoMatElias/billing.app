import { Component, DataType, dynamic } from 'bouerjs'
import html from './sign.in.html';
import { authenticator } from '../../../data/connection';
import { notify } from '../../../helpers/utils';
import AlertIcon from '../../../data/models/enums/alertIcon';


export default class SignIn extends Component {
	readonly name = 'SignIn';
	readonly title = 'Sign In';
	readonly route = '/sign.in.html';
	readonly authKey = 'billing.app.auth';

	readonly data = {
		isShown: false,
		model: {
			username: '',
			password: ''
		}
	};

	constructor() {
		super(html);
	}

	mounted(event: CustomEvent): void {
		if (localStorage.getItem(this.authKey))
			location.href = '/';
	}

	signIn() {
		const bouer = this.bouer!;
		const response = authenticator.signIn(
			this.data.model.username, 
			this.data.model.password
		);

		if (!response.success) {

			notify.call(bouer, {
				message: response.message,
				type: AlertIcon.error
			});

			return;
		}
		
		const jsonData = JSON.stringify(response.data);
		const jsonDataEncoded = btoa(jsonData);

		localStorage.setItem(this.authKey, jsonDataEncoded);
	
		location.href = '/';
	}
}