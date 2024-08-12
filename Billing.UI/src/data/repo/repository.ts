import { dynamic, forEach, isPrimitive } from "bouerjs";
import { toCode } from "../../helpers/utils";
import Include, { IncludeExpression } from "./include";

export default class Repository<T> {
	constructor(document: string, dataSource: any) {
		this.storage = dataSource;
		this.data = dataSource[document];
	}

	private readonly storage: any;
	private readonly data: dynamic<T> = {};
	private readonly fieldsToIgnore = new Set<string>(
		["id", "createdAt", "updatedAt", "isDeleted"]
	);

	save(model: T) {
		let uid = (model as any).id;
		
		uid = (uid || '').length === 0 ? toCode(8) : uid;
		
		this.data[uid] = model;
		return model;
	}

	update(model: T) {
		const uid = (model as any).id;
		const row = this.data[uid] as any;

		if (!row) return false;

		Object.keys(model as any)
			.forEach(k => {
				if (this.fieldsToIgnore.has(k)) return;

				const value = (model as any)[k];

				if (!isPrimitive(value)) return;
				if (!value) return;

				row[k] = value;
			});

		return true;
	}

	delete(model: T) {
		const uid = (model as any).id;
		const isDeleted = delete this.data[uid];
		return isDeleted;
	}

	find(
		predicate: (item: T) => boolean,
		includes?: IncludeExpression<T>
	) {
		return Include.dispatch(this.findAll().find(item => {
			return predicate(item);
		}), includes);
	}

	findById(
		uid: string,
		includes?: IncludeExpression<T>
	) {
		return Include.dispatch(this.data[uid], includes);
	}

	findAll(
		// The predicate
		predicate?: (item: T) => boolean,
		includes?: IncludeExpression<T>
	) {
		const data = Object.values(this.data);

		if (!predicate) return Include.dispatch(data, includes);

		return Include.dispatch(data.filter(item => {
			return predicate(item);
		}), includes);
	}
}