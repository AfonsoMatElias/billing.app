import { Component, dynamic } from "bouerjs";

import { dataContext } from "../../../../data/connection";
import Country from "../../../../data/models/country";
import Gender from "../../../../data/models/enums/gender";
import Provider from "../../../../data/models/provider";
import Province from "../../../../data/models/province";
import { notify, toObject } from "../../../../helpers/utils";
import html from './view.html';

const pageHeader = 'View • Provider';

export default class View extends Component {
	constructor() {
		super(html);
	}
	
	readonly title = pageHeader;
	readonly route = "/view/{id}";
	inputFile?: HTMLInputElement;

	readonly data = {
		// Variables
		locked: true,
		id: this.params().id,
		model: toObject<Provider>(),
		genders: new Array<dynamic>(),
		countries: new Array<Country>(),
		provincies: new Array<Province>(),
	}

	mounted(): void {
		const data = this.bouer!.data;
		data.currentPage = pageHeader;
	}

	loaded(evt: CustomEvent): void {
		const bouer = this.bouer!;
		this.inputFile = (evt.currentTarget as Element)!.querySelector('input[type="file"]') as HTMLInputElement;
		
        bouer.$routing.markActiveAnchor(bouer.el!.querySelector('.provider-link')!);

		this.data.id = (this.params() as any).id
		this.data.countries = dataContext.country.findAll();
		this.data.genders = Object.keys(Gender).map((k: any) => {
			return {
				id: k,
				name: (Gender as any)[k]
			}
		});

		const $data = dataContext.provider.findById(this.data.id);

		if (!$data) {
			return notify.call(bouer, {
				message: 'Provider `'+ this.data.id +'` not found!',
				run: () => {
					window.history.back();
				}
			});
		}

		// Fill out the reference data
		if ($data.provinceId) {
			const province = dataContext.province.findById($data.provinceId, (row, ds) => {
				return {
					country: ds.country.findById(row.countryId)
				}
			});
			
			$data.province = province;
			this.data.provincies = [province]; 
		}

		this.data.model = $data;
	}

	save(evt: CustomEvent) {}

	remove(evt: CustomEvent) {}
}