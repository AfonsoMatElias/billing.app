import { forEach } from "bouerjs";
import Category from "./models/category";
import Country from "./models/country";
import Customer from "./models/customer";
import Employee from "./models/employee";
import PaymentMethod from "./models/paymentMethod";
import Product from "./models/product";
import Provider from "./models/provider";
import Province from "./models/province";
import Stock from "./models/stock";
import Store from "./models/store";
import SubCategory from "./models/subCategory";
import Repository from "./repo/repository";

const entity_ucode = "etty_u_code_00"

export default class DataContext {
	category: Repository<Category> = null as any;
	country: Repository<Country> = null as any;
	customer: Repository<Customer> = null as any;
	employee: Repository<Employee> = null as any;
	product: Repository<Product> = null as any;
	provider: Repository<Provider> = null as any;
	province: Repository<Province> = null as any;
	store: Repository<Store> = null as any;
	subCategory: Repository<SubCategory> = null as any;
	stock: Repository<Stock> = null as any;
	paymentMethod: Repository<PaymentMethod> = null as any;

	constructor(dataSource: any) {
		const source = dataSource[entity_ucode];
		const keys = Object.keys(source);
		const _this = this as any;

		// Filling all the properties
		forEach(keys, (key: any) => {
			_this[key] = new Repository<any>(key, source);
		});
	}
}