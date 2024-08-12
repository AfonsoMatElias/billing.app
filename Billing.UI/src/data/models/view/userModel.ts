import Employee from "../employee";
import User from "../user"

export default interface UserModel extends User {
	employee?: Employee
}