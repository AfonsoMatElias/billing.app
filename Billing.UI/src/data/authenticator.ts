import { dynamic } from "bouerjs";
import { toCode, toObject } from "../helpers/utils";
import Employee from "./models/employee";
import User from "./models/user";
import usersStorage from "./seeds/user.seed";
import UserRole from "./models/enums/userRole";
import DataContext from "./dataContext";
import Repository from "./repo/repository";
import UserModel from "./models/view/userModel";

type AuthResponse = {
	data?: any
	success: boolean,
	message: string
}

export default class Authenticator {
	constructor(dataContext: DataContext) {
		this.users = usersStorage;
		this.employeeRepo = dataContext.employee;
	}

	readonly employeeRepo: Repository<Employee>;
	readonly users: dynamic<User> = {};

	signIn($username: string, $password: string): AuthResponse {

		if (!$username) return {
			message: "Invalid username",
			success: false,
		};

		const mUsername = $username.toUpperCase();
		const userDb = this.users[mUsername];

		const notLogged = {
			message: "Invalid username/password",
			success: false,
		};

		if (!userDb) return notLogged;

		if (userDb.password !== $password)
			return notLogged;

		const userData: UserModel = Object.assign({}, userDb); 

		userData.employee = this.employeeRepo.find(x => x.userId == userDb.id);
		userData.password = "<hidden>";

		return {
			data: userData,
			message: "Done",
			success: true,
		};
	}

	signUp(model: UserModel): AuthResponse {
		if (!model) return {
			message: "Invalid request model",
			success: false,
		};

		const employee = model.employee!;
		delete model.employee;
		 
		if (!employee) return {
			message: "Invalid request model",
			success: false,
		};

		const user = model;

		// Setting values
		user.id = toCode();

		employee.id = toCode();
		employee.ucode = ("Emp:" + toCode()).toUpperCase()
		employee.userId = user.id;

		user.role = UserRole.Manager;

		// Saving the employee
		this.employeeRepo.save(employee);

		this.users[user.username.toUpperCase()] = user;

		return {
			data: model,
			message: "Done",
			success: true
		};
	}

	checkUsername(username: string): AuthResponse  {

		if (!username) return {
			message: "Invalid username",
			success: false,
		};
		
		const user = this.users[username.toUpperCase()];
		
		if (user) return {
			message: "Username already taken",
			success: false,
		};

		return {
			message: "Valid username",
			success: true,
		}; 
	}

	repo() {
		return new Repository<User>('user', { 'user': usersStorage })
	}
}