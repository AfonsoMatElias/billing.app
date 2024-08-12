import Bouer, { code, dynamic, webRequest } from "bouerjs";
import AlertModel from "../data/models/view/AlertModel";
import AlertIcon from "../data/models/enums/alertIcon";

export function web(this: Bouer, path: string, method?: string, body?: BodyInit, headers?: HeadersInit) {
	return webRequest(path, {
		body: body,
		method: method || 'get',
		headers: headers || {
			'Accept': "application/json",
			'Content-Type': "application/json",
			'Authorization': sessionStorage.token || undefined
		},
	}).then(response => {
		if (response.ok)
			return response.json();
		throw new Error(response.statusText);
	}).then(serverResponse => {
		if (!serverResponse.success)
			throw new Error(serverResponse.errors.join('\n'));

		return serverResponse;
	}).catch(error => {
		if (error.message === 'Unauthorized')
			return;

		// dynamically bound the context
		const bouer = (this as any) as Bouer;
		bouer.emit('notify', {
			init: {
				detail: {
					type: 'error',
					content: error
				}
			}
		});

		throw error;
	});
}

export function notify(this: Bouer, alert: AlertModel) {
	let messageData = alert.message;

	if (messageData instanceof Object) {
		messageData = "Ocorreu um erro não identificado."
		console.error('[Unknown Error]:', alert.message);
	}

	if (!alert.type) alert.type = AlertIcon.info;

	alert.message = encodeURI(messageData);

	if (alert.url) alert.url = encodeURI(alert.url);
	else alert.url = undefined;

	this.data.alerts.push(alert);

	if (alert.run !== undefined) {
		setTimeout(function () {
			alert.run!(alert);
		}, 2500);
	}
}

export function calculateNotificationPeriod(input: string) {
	let d = Math.abs(new Date(input) as any - (new Date() as any)) / 1000;
	const r: dynamic = {};
	const s: dynamic<number> = {
		$1ano: 31536000,
		$2mes: 2592000,
		$3semana: 604800,
		$4dia: 86400,
		$5hora: 3600,
		$6minuto: 60,
		$7segundo: 1,
	};

	Object.keys(s).forEach(function (key) {
		r[key] = Math.floor(d / s[key]);
		d -= r[key] * s[key];
	});

	function buildMessage(v: number, label: string) {
		return "há " + v + " " + label + (v == 1 ? "" : "s");
	}

	var message = "";
	var keys = Object.keys(r);
	for (var key of keys) {
		var value = r[key];
		if (value > 0 && message == "") {
			var _key = key.substring(2);
			message = buildMessage(
				value,
				_key == "mes" ? (value == 1 ? "mês" : "meses") : _key
			);
		}
	}

	return message || "agora mesmo";
}

export function toHumanBirthday(date: Date | string) {
	if (!date) return 'N/A';

	const jsonDate = date instanceof Date ? date.toJSON() : date; 

	const datePart = jsonDate.split('T')[0].split('-');
	const monthMap = [
		'Janeiro', 'Fevereiro', 'Março',
		'Abril', 'Maio', 'Junho', 'Julho',
		'Agosto', 'Setembro', 'Outubro',
		'Novembro', 'Dezembro'
	];

	const day = datePart[2];
	const month = monthMap[(Number(datePart[1]) - 1)];
	const year = datePart[0];

	return day + ' de ' + month + ' de ' + year;
}

export function toDate(date: Date | string) {
	if (!date) return 'N/A';
	const jsonDate = date instanceof Date ? date.toJSON() : date; 
	return new Date(Date.parse(jsonDate))
		.toLocaleDateString('pt');
}

export function addOrRemSpinner(btn: Element, isRemove?: boolean) {
	const classList = btn.classList;
	const loadingClass = 'is-loading';
	if (isRemove) {
		classList.remove(loadingClass);
		return;
	}

	classList.add(loadingClass);
}

export function hasSpinner(btn: Element) {
	return btn.classList.contains('is-loading');
}

export function getAchronym(value: string) {
	if (!value) return '#';
	const _splitted = value.split(' ');

	return _splitted[0][0] + ((_splitted[1] || '')[0] || '');
}

export function signOut() {
	sessionStorage.removeItem('token');
	window.location.href = '/sign.in.html';
}

export function toProductImage(product: any) {
	const defaultImage = '/assets/images/box.svg';

	if (!product || !product.images || product.images.length == 0)
		return defaultImage;

	return product.images[0].url || defaultImage;
}

export function aboveMe(me: Element, selector?: string) {
	var doc = document;
	// Parent getter
	function parent(elem: Node): Node | null {
		var $node = elem.parentNode;

		if (!(selector)) return $node;
		if ($node === doc || !($node)) return null;

		var tester = doc.createElement('body');
		tester.innerHTML = ($node as any).outerHTML;

		if ($node.nodeName === tester.nodeName)
			tester.innerHTML = '';
		else
			tester.children[0].innerHTML = '';

		if (tester.querySelector(selector))
			return $node;
		else if ($node.nodeName === tester.nodeName)
			return null;
		else
			return parent($node);
	}
	// Getting the parent
	return parent(me);
}

export function toCode(len?: number) {
	return code(len);
}

export function toFullName(...names: string[]) {
	return names.join(' ').trim()
}

export function toObject<T = dynamic>() {
	const emptyObject: T = {} as any; 
	return Object.assign({}, emptyObject);
}

export function toNullType<T>(init?: any): T | null {
	const emptyObject: T =  init; 
	return emptyObject;
}