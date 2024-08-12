import UserRole from "./enums/userRole"

export default interface User {
	id: string
	username: string
	password: string
	role: UserRole
	
	createdAt: Date
	updatedAt: Date
	isDeleted: boolean
}