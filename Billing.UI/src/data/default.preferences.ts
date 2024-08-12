export default {
	darkMode: {
		name: 'Dark Mode',
		description: 'Adjust the appearance of Billing to reduce glare and give your eyes a break.',
		value: false
	},
	lowStockPopUp: {
		name: 'Low Stock Notification PopUp',
		description: 'Allow the popup to appear if the stock of a product is low.',
		value: true
	},
	currency: {
		name: 'Currency',
		description: 'Allow change the currency of the application according to your country',
		type: 'select',
		value: 'AOA',
		data: [
			{
				code: 'AOA',
				name: 'Angolan Kwanza',
				sym: 'AOA'
			},
			{
				code: 'USD',
				name: 'US Dollar',
				sym: '$'
			},
			{
				code: 'EUR',
				name: 'Europea',
				sym: '€'
			},
		]
	},
	
};