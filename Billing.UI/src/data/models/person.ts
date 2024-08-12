import Province from "./province"

export default interface Person {
	photo?: string;
	birthday?: Date
	idCard: string

	firstName: string
	lastName?: string
	gender?: string

	phone?: string
	email?: string

	provinceId?: string
	province?: Province
	address?: string

	createdAt: Date
	updatedAt: Date
	isDeleted: boolean
}