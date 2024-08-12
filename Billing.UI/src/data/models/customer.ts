import Person from "./person"

export default interface Customer extends Person {
	id: string
	ucode: string
	lastBuy?: Date
}