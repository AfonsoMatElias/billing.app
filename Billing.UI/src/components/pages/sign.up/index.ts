import { Component } from 'bouerjs'
import html from './sign.up.html';

export default class SignUp extends Component {
	name = 'SignUp';
	title = 'Sign Up';
	route = '/sign.up.html';
	
	constructor() {
		super(html);
	}
}