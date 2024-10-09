
import { Component } from "bouerjs";

import html from './app.html';

import SignIn from "./pages/sign.in";
import SignRecover from "./pages/sign.recover";
import SignUp from "./pages/sign.up";

import NotFound from "./pages/404";
import CustomerComponent from "./pages/customer";
import Dashboard from "./pages/dashboard";
import ProductComponent from "./pages/product";
import ProviderComponent from "./pages/provider";
import SellComponent from "./pages/sell";
import SettingsComponent from "./pages/settings";
import StockComponent from "./pages/stock";

import ChatComponent from "./pages/chat";
import CreatePerson from "./widgets/person/create-person";
import Popup from "./widgets/popup";
import Table from "./widgets/table";
import AlertIcon from "../data/models/enums/alertIcon";
import { notify } from "../helpers/utils";

export default class AppComponent extends Component {
	readonly name: string = 'AppComponent';

	constructor() {
		super(html);
	}

	children = [
		Popup,
		Table,
		CreatePerson,

		SignIn,
		SignUp,
		SignRecover,
		NotFound,

		ProductComponent,
		CustomerComponent,
		ProviderComponent,
		SellComponent,
		StockComponent,
		ChatComponent,

		Dashboard,
		SettingsComponent,
	];

	beforeLoad() {
		const bouer = this.bouer!;

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
			if (bouer.data.pageLoading == true && pagesLoading === 0)
				bouer.data.pageLoading = false;
		}

		bouer.on("component:requested", () => {
			pagesLoading++;
			if (bouer.data.pageLoading === false) bouer.data.pageLoading = true;
		});

		// Everything loaded
		bouer.on("component:loaded", function () {
			decreasePageLoaded();
		});

		// If some page is blocked, then load the main page
		bouer.on("component:blocked", function () {
			decreasePageLoaded();
		});

		bouer.on("component:fail", () => {
			decreasePageLoaded();

			// bouer.emit('notify', {
			// 	data: {
			// 		type: '',
			// 		message: '',
			// 		run: () => {}
			// 	}
			// });

			notify.call(bouer, {
				message: "Página ou ficheiro não encontrado!",
				type: AlertIcon.error,
			});
		});


		bouer.on('notify', evt => {
			notify.call(bouer, {
				type: evt.detail.type || AlertIcon.error,
				message: evt.detail.message,
				run: evt.detail.run || function () { }
			});
		});

		if (isInNoAuthRequiredPages) return;

		bouer.globalData.user = JSON.parse(atob(authTokenData));
		const preferences = bouer.globalData.preferences;

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

						bouer.$skeleton.set({
							background: '#3a3b3b',
							wave: '#16171b'
						});
					} else {
						document.documentElement.classList
							.replace(dark, light);

						bouer.$skeleton.set({})
					}

					bouer.emit('onThemeChange', { init: { detail: { isDark: v } } });
				}

				setDarkMode(pref.value);

				bouer.watch('value', (n) => {
					setDarkMode(n);
				}, pref);
			}
		}
	}
}