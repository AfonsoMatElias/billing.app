import { toCode } from "../../helpers/utils";
import Product from "../models/product";

const products: { [key: string]: Product } = {
	"0001": {
		id: '0001',
		isDeleted: false,
		createdAt: new Date(),
		updatedAt: new Date(),
		uid: toCode(6),
		name: 'Coca Cola',
		info: 'Coca Cola 500 ml',
		code: '123456789',
		description: 'N/A',
		price: 150,
		iva: 14,
		isStock: true,
		subCategoryId: '0001',
		stocks: [],
		images: [
			{
				createdAt: new Date(),
				id: '1',
				name: 'Coca Cola',
				productId: '0001',
				uid: 'abc',
				url: ''	
			}
		]
	}
};

export default products;