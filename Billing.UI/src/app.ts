import Bouer from "bouerjs";

import './assets';

// main pages
import './index.html';
import './sign.in.html';
import './sign.up.html';
import './sign.recover.html';

import components from "./components";
import { AlertModel, ProductModel } from './model';
import { notify } from "./helpers/utils";

console.log(new Bouer('body', {
	components,
	data: {
		alerts: [] = new Array<AlertModel>,
		baseUrl: "http://localhost:5000/api/",

		// Variables
		currentPage: "None",
		pageLoading: false,
		showNotification: false,
		showConversation: false,
		showProfile: false,

		openedMenu: null,

		products: new Array<ProductModel>(),
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
			// this.data.application.token = '';
			// window.location.href = '/index.html';
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
		}
	},

	globalData: {
		application: {
			token: '',
			role: 'Perfil',
			user: {
				id: '',
				nome: '',
				userName: '',
				user: {}
			}
		},
		preferences: []
	},

	config: {
		usehash: false,
		prefetch: true,
		skeleton: {
			numberOfItems: 5
		}
	},

	beforeLoad() {
		const noTokenRequiredPages = [
			"/sign.in.html",
			"/sign.up.html",
			"/sign.recover.html",
		];

		const isInNoTokenRequiredPages = noTokenRequiredPages.find(
			item => window.location.href.includes(item)
		) != null;

		// if (isInNoTokenRequiredPages && sessionStorage.token)
		// 	return (window.location.href = "/");
		// else if (!isInNoTokenRequiredPages && !sessionStorage.token)
		// 	return (window.location.href = "/sign.in.html");

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
				type: "error",
			});
		});

		this.on('notify', evt => {
			notify.call(this as Bouer, {
				type: evt.detail.type || 'error',
			 	message: evt.detail.content
			});
		});

		if (isInNoTokenRequiredPages) return;

		// this.deps.web('sign/account')
		// 	.then(response => { });
		// 	.then(function (response) {
		// 		var data = response.data;

		// 		var preferences = data.preferences;
		// 		delete data.preferences;

		// 		// Setting user data
		// 		bouer.set(data, bouer.globalData.application.user);

		// 		function addWatch(preference, prefName, bindKey) {
		// 			bouer.watch(bindKey, (v) => {
		// 				bouer.deps['web']('preferences/' + prefName + '/?prefValue=' + v, 'PUT', {})
		// 					.then();
		// 			}, preference);
		// 		}

		// 		// Updates uuser preferences in the server if it changes
		// 		for (var key of Object.keys(preferences)) {
		// 			var pref = preferences[key];

		// 			pref.key = key;

		// 			bouer.globalData.preferences.push(pref);
		// 			addWatch(pref, key, 'value');

		// 			if (key === 'DarkMode') {
		// 				// Defining and adding calling the function to apply the mode
		// 				function setDarkMode(v) {
		// 					var dark = "dark-mode",
		// 						light = "light-mode";
		// 					if (v) {
		// 						document.documentElement.classList.replace(light, dark);

		// 						bouer.$skeleton.set({
		// 							background: '#3a3b3b',
		// 							wave: '#16171b'
		// 						});
		// 					} else {
		// 						document.documentElement.classList.replace(dark, light);
		// 						bouer.$skeleton.set({})
		// 					}

		// 					bouer.emit('onDarkModeChange', {
		// 						init: { detail: { value: v } }
		// 					});
		// 				}

		// 				setDarkMode(pref.value);
		// 				bouer.watch("value", setDarkMode, pref);
		// 			}
		// 		}
		// 	});

		// var jwtObj = JSON.parse(atob(sessionStorage.token.split(' ')[1].split('.')[1]))

		// this.globalData.application.role = Array.isArray(jwtObj.role) ? jwtObj.role[0] : jwtObj.role;
	},
	loaded() {
		// if (typeof signHandler === 'function') signHandler.call(this);
	},
}));