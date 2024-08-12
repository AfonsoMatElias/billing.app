import Person from "./person"

export default interface Provider extends Person {
	id: string
	ucode: string
}