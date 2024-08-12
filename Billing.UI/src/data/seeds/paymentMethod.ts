import PaymentMethod from "../models/paymentMethod";

const paymentMethods: { [key: string]: PaymentMethod } = {
	"0001": {
		id: "0001",
		name: "Cash",
		createdAt: new Date(),
		isDeleted: false
	},
	"0002": {
		id: "0002",
		name: "Cartão",
		createdAt: new Date(),
		isDeleted: false
	}
};

export default paymentMethods;