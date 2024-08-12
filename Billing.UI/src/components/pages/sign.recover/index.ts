import { Component } from 'bouerjs'
import html from './sign.recover.html';

export default class SignRecover extends Component {
	readonly name = 'SignRecover';
	readonly title = 'Sign Recover';
	readonly route = '/sign.recover.html';

	constructor() {
		super(html);
	}
}