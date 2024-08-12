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

import CreatePerson from "./widgets/person/create-person";
import Popup from "./widgets/popup";
import Table from "./widgets/table";
import ChatComponent from "./pages/chat";

const components = [
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
]

export default components;