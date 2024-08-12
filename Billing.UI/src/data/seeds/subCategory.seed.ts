import SubCategory from "../models/subCategory";

const subCategories: { [key: string]: SubCategory } = {
	"0001": {
		id: "0001",
		name: "Refrigerante",
		categoryId: "0001",
		createdAt: new Date()
	},
	"0002": {
		id: "0002",
		name: "Cerveja",
		categoryId: "0001",
		createdAt: new Date()
	},
	"0003": {
		id: "0003",
		name: "TV",
		categoryId: "0002",
		createdAt: new Date()
	},
	"0004": {
		id: "0004",
		name: "Telefone",
		categoryId: "0002",
		createdAt: new Date()
	}
};

export default subCategories;