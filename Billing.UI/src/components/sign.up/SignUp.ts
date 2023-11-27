import { Component } from 'bouerjs'
import html from './SignUp.html';

export default class SignUp extends Component {
	readonly title = 'Sign Up';
	readonly route = '/sign.up.html';
	
	constructor() {
		super(html);
	}
}