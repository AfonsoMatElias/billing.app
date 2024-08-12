import Customer from "../models/customer";

const customers: { [key: string]: Customer } = {
	"0011": {
		id: "0011",
		photo: '',
		birthday: new Date(),
		idCard: '003715524LA037',

		firstName: 'Liano',
		lastName: 'Vaz',
		gender: 'M',

		phone: '+244924473114',
		email: 'liano.vaz@hotmail.com',

		provinceId: '0001',
		address: 'Edificio 50, Avenida Hoji-ya-Henda',

		createdAt: new Date(),
		updatedAt: new Date(),
		lastBuy: new Date(),
		isDeleted: false,
		ucode: "001122"
	}
};

export default customers;