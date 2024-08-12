import { Component } from "bouerjs";

import { dataContext } from "../../../../data/connection";
import Category from "../../../../data/models/category";
import Provider from "../../../../data/models/provider";
import SubCategory from "../../../../data/models/subCategory";
import { aboveMe, addOrRemSpinner, hasSpinner, toCode } from "../../../../helpers/utils";
import html from './create.html';
import Product from "../../../../data/models/product";
import ProductImage from "../../../../data/models/productImage";
import Store from "../../../../data/models/store";
import UserModel from "../../../../data/models/view/userModel";

const pageHeader = "Product • Create";

type BoxImage = { 
	id: string, 
	url: string, 
	index: number,
	file: DataTransferItem
};

export default class Create extends Component {
	constructor() {
		super(html);
	}

	readonly title = pageHeader;
	readonly route = "/create";
	boxClass:string = 'drag-over';
	dataTransfer = new DataTransfer();
	photoInputElement?: HTMLInputElement;

	readonly data = {
		buyInfo: true,
		isStock: false,
		isDestroyable: false,
		userStore: '',

		providers: new Array<Provider>(),
		categories: new Array<Category>(),
		subCategories: new Array<SubCategory>(),
		boxImages: new Array<BoxImage>(),
		stores: new Array<Store>(),

		motivosIsencao: [
			{
				id: 0,
				nome: "Consumível",
				descricao: "Produto Consumível"
			}
		],
		toCode
	}

	mounted(): void {
		const data = this.bouer!.data;
		data.currentPage = pageHeader;
	}

	loaded(evt: CustomEvent): void {
		const el = evt.target as Element;
		const bouer = this.bouer!;
		// Marking the menu
		bouer!.$routing.markActiveAnchor(bouer.el!.querySelector('.product-link')!);

		// Loading all the data
		this.data.providers = dataContext.provider.findAll();
		this.data.categories = dataContext.category.findAll();
		this.data.stores = dataContext.store.findAll();

		const user: UserModel = this.bouer!.globalData.user;
		this.data.userStore = user.employee?.storeId || ''; 

		this.photoInputElement = el.querySelector('#product-images')!;
	}

	// Methods
	selectCategoria(item: HTMLSelectElement) {
		if (item.value == '') return this.data.subCategories = [];
		this.data.subCategories = dataContext.subCategory.findAll(x => x.categoryId === item.value);
	}

	removeImage(image: BoxImage, evt: Event) {
		
		const el = aboveMe(evt.currentTarget as Element, '.image-loaded')!;
		
		// Finding the image index
		const imageIndex = this.data.boxImages.indexOf(image);

		// Removing it
		this.data.boxImages.splice(imageIndex, 1);

		// Removing it on DataTranf
		this.dataTransfer.items.remove(image.index);
	}

	processUploadedImages(dtTransfer: any) {
		let availableSpace = 3 - this.data.boxImages.length;
		if (availableSpace === 0) return;

		if (dtTransfer) {
			// Getting position to use in the UI
			let index = this.dataTransfer.items.length == 0 ? 0 : this.dataTransfer.items.length - 1;

			for (const file of dtTransfer.files) {
				const reader = new FileReader();
				reader.addEventListener('load', (data: any) => {

					this.data.boxImages.push({
						id: toCode(4),
						index: index,
						url: data.target.result,
						file: file
					});

				});

				this.dataTransfer.items.add(file);

				if (availableSpace === 0) break;
				reader.readAsDataURL(file);
				availableSpace--;
			}
		}

		// Adding elements into fileElement
		this.photoInputElement!.files = this.dataTransfer.files;

	}

	uploadImages(evt: any) {
		evt.target.classList.remove(this.boxClass);
		this.processUploadedImages(evt.target);
	}

	drop(evt: any) {
		evt.currentTarget.classList.remove(this.boxClass);
		this.processUploadedImages(evt.dataTransfer);
	}

	dragIn(evt: any) {
		if (evt.target.classList.contains(this.boxClass)) return;
		evt.target.classList.add(this.boxClass);
	}

	dragOut(evt: any) {
		if (!evt.target.classList.contains(this.boxClass)) return;
		evt.target.classList.remove(this.boxClass);
	}

	submit(evt: Event) {
		let btn = evt.currentTarget as any;
		const bouer = this.bouer!;

		if (hasSpinner(btn)) return;
		addOrRemSpinner(btn);

		const form = aboveMe(btn, '[post-form]')! as HTMLFormElement;

		const productModel = bouer.toJsObj(form) as Product;
		const productStocks = productModel.stocks;

		productModel.id = toCode();
		productModel.stocks = [];

		productModel.code = productModel.code ?? (new Date().getTime() + "").substring(4)
		productModel.images = this.data.boxImages.map(image => {
			const item: ProductImage = {
				id: toCode(),
				uid: toCode(),
				url: image.url,
				createdAt: new Date(),
				name: image.file.getAsFile()!.name,
				productId: productModel.id
			};

			return item;
		});

		// Saving product data
		dataContext.product.save(productModel);

		// Saving stock data
		productStocks.forEach(s => {
			s.isActive = true;
			s.code = toCode();
			s.productId = productModel.id;			
			dataContext.stock.save(s);
		});

		addOrRemSpinner(btn, true);
	}

	cancel(evt: Event) {
		(aboveMe(evt.currentTarget as any, '[post-form]') as HTMLFormElement)
			.reset();
		
		const imageArea = this.el!.querySelector('.image-load-area')!;
		imageArea.innerHTML = '';
	}
}