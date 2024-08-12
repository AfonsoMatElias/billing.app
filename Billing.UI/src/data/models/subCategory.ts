import Category from "./category"

export default interface SubCategory {
	id: string
	name: string
	
	categoryId: string
	category?: Category
	createdAt: Date
}