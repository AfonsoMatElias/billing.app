import Bouer from "bouerjs";

import './assets';

// main pages
import './index.html';
import './sign.in.html';
import './sign.recover.html';
import './sign.up.html';

import AppComponent from "./components/app";
import defaultPreferences from "./data/default.preferences";
import UserModel from "./data/models/view/userModel";
import { calculateNotificationPeriod, getAchronym, toDate, toFullName, toHumanBirthday, toObject } from "./helpers/utils";
import AlertModel from "./data/models/view/AlertModel";

new Bouer('body', {
	config: {
		usehash: false,
		prefetch: true,
		skeleton: {
			numberOfItems: 5
		}
	},

	data: {
		alerts: [] = new Array<AlertModel>(),

		// Variables
		currentPage: "None",
		pageLoading: false,
		showNotification: false,
		showConversation: false,
		showProfile: false,

		openedMenu: null,

		conversations: [{
			id: 1,
			user: "António Ferraz Lopes",
			message: "Rato, viste como?",
			seen: false,
			date: "2020-09-05T18:30:50.102",
		},
		{
			id: 2,
			user: "Salomão Satuta",
			message: "Fruta, viste como?",
			seen: false,
			date: "2020-09-09T20:30:50.10Z",
		},
		],
		notifications: [{
			id: 1,
			message: "Stock de `Água` está em 5 itens!",
			date: "2020-09-09T18:41:50.102",
		},
		{
			id: 2,
			type: "fa-warning",
			message: "Stock de `Rede` está em 0 itens!",
			date: "2020-09-09T18:26:50.102",
		},
		{
			id: 3,
			message: "Stock de `Rede` está em 5 itens!",
			date: "2020-09-09T18:20:50.102",
		},
		],

		// Methods
		signOut() {
			localStorage.removeItem('billing.app.auth');
			window.location.href = '/sign.in.html';
		},
		openable(evt: Event): any {
			// Toggleable class
			const cls = 'sub-menu-opened';

			// The old submenu
			const old: HTMLElement = this.data.openedMenu as any;

			// Getting the sub menu from clicked menu
			const current = (evt.currentTarget! as Element).nextElementSibling!;

			// Closing the old if needed
			if (old) old.classList.remove(cls);

			// Return if the current is equal to the old and clear storage
			if (current === old) return this.data.openedMenu = null;

			// Opening the current
			if (current) current.classList.add(cls);

			// Storing the current opened
			this.data.openedMenu = current as any;

			[].slice.call(current.querySelectorAll('a')).filter(function (item: HTMLAnchorElement) {
				item.onclick = () => current.classList.remove(cls);
			});
		},
	},

	components: [AppComponent],
	
	globalData: {
		// Vars
		user: toObject<UserModel>(),
		preferences: defaultPreferences,

		toDate,
		getAchronym,
		toHumanBirthday,
		calculateNotificationPeriod,
		toFullName
	},
});