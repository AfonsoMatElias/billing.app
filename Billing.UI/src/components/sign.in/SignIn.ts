import { Component } from 'bouerjs'
import html from './SignIn.html';

export default class SignIn extends Component {
	readonly title = 'Sign In';
	readonly route = '/sign.in.html';

	constructor() {
		super(html);
	}
}