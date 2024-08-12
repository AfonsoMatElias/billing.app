import { Component, dynamic } from "bouerjs"

import html from './create-person.html';
import Country from "../../../data/models/country";
import Province from "../../../data/models/province";
import { aboveMe, toCode } from "../../../helpers/utils";
import { dataContext } from "../../../data/connection";
import Gender from "../../../data/models/enums/gender";

export default class CreatePerson extends Component {
	constructor() {
		super(html);
	}

	readonly name = "create-person";
	readonly dataTransfer = new DataTransfer();
	readonly data = {
		genders: new Array<dynamic>(),
		countries: new Array<Country>(),
		provincies: new Array<Province>(),
		toCode
	}

	photoInputElement?: HTMLInputElement;

	loaded(evt: CustomEvent): void {
		const el = evt.target as Element;

		// Loading all the data
		this.data.countries = dataContext.country.findAll();
		this.data.genders = Object.keys(Gender).map((k: any) => {
			return {
				id: k,
				name: (Gender as any)[k]
			}
		});

		this.photoInputElement = el.querySelector('#product-images')!;
	}

	// Methods
	selectCountry(item: HTMLSelectElement) {
		if (item.value == '') return this.data.provincies = [];
		this.data.provincies = dataContext.province.findAll(x => x.countryId === item.value);
	}

	submit(evt: CustomEvent) {
		const bouer = this.bouer!;

		const submitBtn = evt.currentTarget;

		const formElement = aboveMe(evt.currentTarget as Element, '[post-form]') as HTMLElement;
		const formObj = bouer.toJsObj(formElement);

		bouer.emit('submit:' + this.name, {
			init: {
				detail: {
					btn: submitBtn,
					form: formElement,
					obj: formObj
				}
			}
		})

		// formSumission(function (url, redirectTo) {
		// 	var btn = evt.currentTarget;

		// 	var form = aboveMe(evt.currentTarget, '[post-form]');
		// 	var formObj = bouer.toJsObj(form);

		// 	if (hasSpinner(btn)) return;
		// 	addOrRemSpinner(btn);

		// 	var formData = new FormData();

		// 	formData.append("json", JSON.stringify(formObj));
		// 	for (var file of component.el.querySelector('#image').files) {
		// 		formData.append("file", file);
		// 	}

		// 	web(url, 'post', formData, {
		// 		'Authorization': sessionStorage.token || undefined
		// 	}).then(function (data) {
		// 		notify({
		// 			type: 'success',
		// 			message: 'Registro Efectuado'
		// 		});

		// 		// Waiting 2s to got the next page
		// 		setTimeout(function () {
		// 			bouer.$routing.navigate(redirectTo);
		// 		}, 500);
		// 	}).finally(function () {
		// 		addOrRemSpinner(btn, true);
		// 	})
		// });
	}

	loadImage(evt: CustomEvent) {
		// Getting position to use in the UI
		const inputFile = evt.currentTarget as HTMLInputElement;
		const imageContainer = inputFile.parentNode as HTMLDivElement;

		const file = inputFile.files![0];
		if (file == null) return;

		const reader = new FileReader();
		reader.addEventListener('load', function (data) {
			imageContainer.style.backgroundImage = 'url(' + data.target!.result + ')';
		});
		reader.readAsDataURL(file);
	}

	removeImage(evt: CustomEvent) {
		// const imageContainer = evt.target;
		// const inputFile = imageContainer.querySelector('input');
		// if (inputFile == null) return;

		// inputFile.value = '';
		// imageContainer.setAttribute('style', '');
	}
}