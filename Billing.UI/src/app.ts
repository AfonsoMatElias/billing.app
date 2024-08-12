import Bouer from "bouerjs";

import './assets';

// main pages
import './index.html';
import './sign.in.html';
import './sign.recover.html';
import './sign.up.html';

import components from "./components";
import defaultPreferences from "./data/default.preferences";
import AlertIcon from "./data/models/enums/alertIcon";
import AlertModel from "./data/models/view/AlertModel";
import UserModel from "./data/models/view/userModel";
import { addOrRemSpinner, calculateNotificationPeriod, getAchronym, hasSpinner, notify, toDate, toFullName, toHumanBirthday, toObject } from "./helpers/utils";

new Bouer('body', {
	components,
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

	globalData: {
		// Vars
		user: toObject<UserModel>(),
		preferences: defaultPreferences,

		calculateNotificationPeriod,
		toHumanBirthday,
		toDate,
		addOrRemSpinner,
		hasSpinner,
		getAchronym,
		toFullName
	},

	config: {
		usehash: false,
		prefetch: true,
		skeleton: {
			numberOfItems: 5
		}
	},

	beforeLoad() {
		const noAuthRequiredPages = [
			"/sign.in.html",
			"/sign.up.html",
			"/sign.recover.html",
		];

		const isInNoAuthRequiredPages = noAuthRequiredPages.find(
			item => window.location.href.includes(item)
		) != null;

		const authTokenData = localStorage['billing.app.auth'];

		if (isInNoAuthRequiredPages && authTokenData)
			return (window.location.href = "/");
		else if (!isInNoAuthRequiredPages && !authTokenData)
			return (window.location.href = "/sign.in.html");

		// Is loading something
		let pagesLoading = 0;

		const decreasePageLoaded = () => {
			pagesLoading--;
			if (this.data.pageLoading == true && pagesLoading === 0)
				this.data.pageLoading = false;
		}

		this.on("component:requested", () => {
			pagesLoading++;
			if (this.data.pageLoading === false) this.data.pageLoading = true;
		});

		// Everything loaded
		this.on("component:loaded", function () {
			decreasePageLoaded();
		});

		// If some page is blocked, then load the main page
		this.on("component:blocked", function () {
			decreasePageLoaded();
		});

		this.on("component:fail", () => {
			decreasePageLoaded();

			notify.call(this as Bouer, {
				message: "Página ou ficheiro não encontrado!",
				type: AlertIcon.error,
			});
		});

		this.on('notify', evt => {
			notify.call(this as Bouer, {
				type: evt.detail.type || AlertIcon.error,
				message: evt.detail.message,
				run: evt.detail.run || function () { }
			});
		});

		if (isInNoAuthRequiredPages) return;

		this.globalData.user = JSON.parse(atob(authTokenData));

		const preferences = this.globalData.preferences;

		// Updates uuser preferences in the server if it changes
		for (const key of Object.keys(preferences)) {
			const pref = (preferences as any)[key];

			pref.key = key;

			if (key === 'darkMode') {
				const setDarkMode = (v: any) => {
					const dark = "dark-mode";
					const light = "light-mode";

					if (v) {
						document.documentElement.classList
							.replace(light, dark);

						this.$skeleton.set({
							background: '#3a3b3b',
							wave: '#16171b'
						});
					} else {
						document.documentElement.classList
							.replace(dark, light);

						this.$skeleton.set({})
					}

					this.emit('onThemeChange', { init: { detail: { isDark: v  } } });
				}

				setDarkMode(pref.value);

				this.watch('value', (n) => {
					setDarkMode(n);
				}, pref);
			}
		}

	},
	loaded() {
		// if (typeof signHandler === 'function') signHandler.call(this);
	},
});