import Category from "../models/category";

const categories: { [key: string]: Category } = {
	"0001": {
		id: "0001",
		name: "Liquidos",
		createdAt: new Date(),
		isDeleted: false
	},
	"0002": {
		id: "0002",
		name: "Electrónicos",
		createdAt: new Date(),
		isDeleted: false
	}
};

export default categories;