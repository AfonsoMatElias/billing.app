import { toCode } from "../../helpers/utils";
import Employee from "../models/employee";


const employees: { [key: string]: Employee } = {
	"0001": {
		id: "0001",
		ucode: "Emp:OEHJDQCA",
		storeId: "0001",
		idCard: "003815524LA037",
		firstName: "Afonso",
		lastName: "Matumona",
		userId: "AFONSOMATELIAS",
		createdAt: new Date(),
		updatedAt: new Date(),
		provinceId: '0001',
		isDeleted: false,
	},
	"0002": {
		id: "0002",
		ucode: "Emp:OEHJDQCB",
		storeId: "0001",
		idCard: "003815524LA001",
		firstName: "Maria",
		lastName: "Matumona",
		userId: "MARIAMATGRACIAS",
		createdAt: new Date(),
		updatedAt: new Date(),
		provinceId: '0001',
		isDeleted: false
	},
	"0003": {
		id: "0003",
		ucode: "Emp:OEHJDQCC",
		storeId: "0002",
		idCard: "003815524LA002",
		firstName: "Pereira",
		lastName: "Matumona",
		userId: "HACHRISS",
		createdAt: new Date(),
		updatedAt: new Date(),
		provinceId: '0001',
		isDeleted: false
	},
	"0004": {
		id: "0003",
		ucode: "Emp:OEHJDQCC",
		storeId: "0002",
		idCard: "003815524LA003",
		firstName: "Sebastião",
		lastName: "Matumona",
		userId: "SEBASTIAOMATGOLVA",
		createdAt: new Date(),
		updatedAt: new Date(),
		provinceId: '0001',
		isDeleted: false
	},
	"0005": {
		id: "0003",
		ucode: "Emp:OEHJDQCC",
		storeId: "0001",
		idCard: "003815524LA004",
		firstName: "Isabel",
		lastName: "Matumona",
		userId: "ISABELMATPITRA",
		createdAt: new Date(),
		updatedAt: new Date(),
		provinceId: '0001',
		isDeleted: false
	},
};

export default employees;