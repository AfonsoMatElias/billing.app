import Store from "../models/store";

const stores: { [key: string]: Store } = {
	"0001": {
		id: "0001",
		ucode: "10001",
		name: "Loja Central",
		nif: '500035468',
		address: "Rua 4b, Vila de Cacuaco",	
		provinceId: "0001",
		createdAt: new Date()
	},
	"0002": {
		id: "0002",
		ucode: "10003",
		name: "Loja Viana",
		nif: '500035468',
		address: "Rua 2bc, Vila de Viana",	
		provinceId: "0001",
		createdAt: new Date()
	}
};

export default stores;