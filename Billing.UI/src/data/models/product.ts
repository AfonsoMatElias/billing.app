import ProductImage from "./productImage";
import Stock from "./stock";
import SubCategory from "./subCategory";

export default interface Product {
	id: string
	createdAt: Date
	updatedAt: Date
	isDeleted: boolean
	
	uid: string;
	name: string; 
	info: string; 

	code: string;
	description: string; 
	price: number 
	
	iva?: number
	isStock: boolean
	
	subCategoryId: string 
	subCategory?: SubCategory 

	stocks: Stock[]
	images: ProductImage[]
};