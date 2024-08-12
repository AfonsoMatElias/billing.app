import Person from "./person";
import Store from "./store";
import User from "./user";

export default interface Employee extends Person  {
	id: string
	ucode: string

	storeId: string
	store?: Store

	userId: string
	user?: User
}