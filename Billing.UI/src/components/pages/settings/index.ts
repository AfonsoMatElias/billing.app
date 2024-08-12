import { Component } from "bouerjs";
import { aboveMe } from "../../../helpers/utils";

// Items
import SettingsMenu from "./widgets/settings-menu";

// Children
import About from "./about";
import Employees from "./employees/list";
import License from "./license";
import Management from "./management";
import Preferences from "./preferences";
import Profile from "./profile";
import StoreComponent from "./stores";
import FormDynamic from "./widgets/form";

export default class SettingsComponent extends Component {
	readonly route = '/settings';

	readonly children = [
		SettingsMenu,
		FormDynamic,

		Profile,
		Employees,
		StoreComponent,
		Preferences,
		Management,
		License,

		About
	];

	data = {
		aboveMe
	};

	constructor() {
		super();
	}

	mounted(evt: CustomEvent): void {
		this.bouer!.$routing.navigate('/settings/profile');
	}
}