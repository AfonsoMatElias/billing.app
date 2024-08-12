import { Component, forEach, IEventSubscription } from "bouerjs";

import { aboveMe } from "../../../../helpers/utils";
import html from './create.html';

const pageHeader = "Create • Customer";

export default class Create extends Component {
	constructor() {
		super(html);
	}

	readonly title = pageHeader;
	readonly route = "/create";

	subscriptions: IEventSubscription[] = [];

	mounted(): void {
		const data = this.bouer!.data;
		data.currentPage = pageHeader;
	}

	loaded(evt: CustomEvent): void {
		const el = evt.target as Element;
		const bouer = this.bouer!;
		// Marking the menu
		this.bouer!.$routing.markActiveAnchor(bouer.el!.querySelector('.customer-link')!);

		this.subscriptions = [
			bouer.on('submit:create-person', (evt) => this.submit(evt))
		];
	}

	submit(evt: CustomEvent) {
		console.log(evt);
	}

	cancel(evt: CustomEvent) {
		(aboveMe(evt.currentTarget as any, '[post-form]') as HTMLFormElement)
			.reset();

		const imageArea = this.el!.querySelector('.image-load-area')!;
		imageArea.innerHTML = '';
	}

	destroyed(evt: CustomEvent): void {
		forEach(this.subscriptions, sub => sub.destroy());
	}
}