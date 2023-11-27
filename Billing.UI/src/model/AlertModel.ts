export default interface AlertModel {
	message: string | object,
	type: string,
	url?: string,
	run?: (alert: AlertModel) => void,
	[k: string]: any
}