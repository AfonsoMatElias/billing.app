import AlertIcon from "../enums/alertIcon";

export default interface AlertModel {
	message: string | object,
	type?: AlertIcon | string,
	url?: string,
	run?: (alert: AlertModel) => void,
	[k: string]: any
}