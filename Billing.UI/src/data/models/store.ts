import Employee from "./employee";
import Province from "./province";

export default interface Store {
	id: string
    nif: string
	ucode: string
	name: string
    address: string

    managerId?: string
    manager?: Employee

	provinceId: string
	province?: Province
	createdAt: Date
}