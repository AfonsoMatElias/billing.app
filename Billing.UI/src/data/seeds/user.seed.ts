import User from "../models/user";
import UserRole from "../models/enums/userRole";

const users: { [username: string]: User } = {
	"AFONSOMATELIAS": {
		id: "AFONSOMATELIAS",
		createdAt: new Date(),
		updatedAt: new Date(),
		isDeleted: false,
		role: UserRole.Admin,

		username: "AfonsoMatElias",
		password: "123",
	},
	"HACHRISS": {
		id: "HACHRISS",
		createdAt: new Date(),
		updatedAt: new Date(),
		isDeleted: false,
		role: UserRole.Manager,

		username: "Hachriss",
		password: "123",
	},
	"MARIAMATGRACIAS": {
		id: "MARIAMATGRACIAS",
		createdAt: new Date(),
		updatedAt: new Date(),
		isDeleted: false,
		role: UserRole.Cashier,

		username: "MariaMatGracias",
		password: "123",
	},
	"SEBASTIAOMATGOLVA": {
		id: "SEBASTIAOMATGOLVA",
		createdAt: new Date(),
		updatedAt: new Date(),
		isDeleted: false,
		role: UserRole.Cashier,

		username: "SebastiaoMatGolva",
		password: "123",
	},
	"ISABELMATPITRA": {
		id: "IsabelMatPitra",
		createdAt: new Date(),
		updatedAt: new Date(),
		isDeleted: false,
		role: UserRole.Cashier,

		username: "IsabelMatPitra",
		password: "123",
	},
};

export default users;