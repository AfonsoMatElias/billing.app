import { Component } from "bouerjs"

import html from './popup.html';

export default class Popup extends Component {
	data = {
		icon: {
			warn: 'fa-warning',
			info: 'fa-info-circle',
			error: 'fa-times-circle',
			success: 'fa-check-circle'
		},
		noClose: false
	}

	constructor() {
		super(html);
	}

	loaded(evt: CustomEvent): void {
		const el = evt.currentTarget!;
		const TIME_SECONDS = 3 * 1000;

		// Time destroyer
		let timer_id: any = null;

		if (this.data.noClose) return;

		const subscribe = () => {
			timer_id = setTimeout(() => {
				this.destroy();
				clearTimeout(timer_id);
			}, TIME_SECONDS);
		}

		subscribe();
		el.addEventListener('mouseover', function () {
			clearTimeout(timer_id);
		});

		el.addEventListener('mouseleave', function () {
			subscribe();
		});
	}
}