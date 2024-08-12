import Country from "./country"

export default interface Province {
	id: string
	name: string
	countryId: string 
	country?: Country 
}