import { Component } from 'bouerjs'
import html from './SignRecover.html';

export default class SignRecover extends Component {
	readonly title = 'Sign Recover';
	readonly route = '/sign.recover.html';

	constructor() {
		super(html);
	}
}