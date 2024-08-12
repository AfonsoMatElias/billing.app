import Provider from "../models/provider";

const providers: { [key: string]: Provider } = {
	"0001": {
		id: "0011",
		photo: '',
		birthday: new Date(),
		idCard: '003715524LA027',

		firstName: 'Antonio',
		lastName: 'Lopes',
		gender: 'M',

		phone: '+244924473114',
		email: 'antonio.lopes@hotmail.com',

		provinceId: '0001',
		address: 'Edificio 55, Avenida Hoji-ya-Henda',

		createdAt: new Date(),
		updatedAt: new Date(),
		isDeleted: false,
		ucode: "331122"
	}
};

export default providers;