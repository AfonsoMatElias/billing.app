import Product from "./product"
import Provider from "./provider"
import Store from "./store"

export default interface Stock {
	id: string
	code: string
	quantity: number
	quantityEntry: number
	quantityMin: number // Min quantity to notify the User

	priceBuy: number
	priceSell: number
	entryDate: Date
	validityDate?: Date
	isActive: boolean

	productId: string
	product?: Product
	
	providerId?: string 
	provider?: Provider 
	
	storeId: string
	store?: Store
}