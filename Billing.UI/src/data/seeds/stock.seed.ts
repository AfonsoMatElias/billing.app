import { toCode } from "../../helpers/utils";
import Stock from "../models/stock";

const stocks: { [key: string]: Stock } = {
	"0001": {
		id: '0001',
		code: toCode(8),
		isActive: true,
		priceBuy: 120,
		priceSell: 150,
		productId: '0001',
		quantityEntry: 20,
		quantity: 15,
		quantityMin: 10,
		entryDate: new Date(),
		validityDate: new Date(new Date().setMonth(new Date().getMonth() + 8)),
		storeId: '0011',
		providerId: '0001',
	},
	"0002": {
		id: '0002',
		code: toCode(8),
		isActive: false,
		priceBuy: 120,
		priceSell: 150,
		productId: '0001',
		quantityEntry: 20,
		quantity: 5,
		quantityMin: 10,
		entryDate: new Date(),
		validityDate: new Date(new Date().setMonth(new Date().getMonth() + 12)),
		storeId: '0011',
		providerId: '0001',
	},
};

export default stocks;