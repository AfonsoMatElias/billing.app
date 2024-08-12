import { forEach } from "bouerjs";
import DataContext from "../dataContext";
import { dataContext } from "../connection";

// Original from Chat GPT

/* Peace of Art
type Include<T extends Record<string, any>> = {
	[K in keyof T]?: T[K] extends (infer U)[]
		? U extends Record<string, any>
			? Include<U>
			: never
		: T[K] extends object | undefined
		? Include<NonNullable<T[K]>> | boolean
		: boolean;
};
*/

export type IncludeExpression<T> = (row: T, dataContext: DataContext) => {
	[K in keyof T]?: any
};

export default class Include {

	private static applyIncludeObject<T>(
		dataContext: DataContext,
		data: any,
		includes?: IncludeExpression<T>
	) {
		// Running the include expression
		const response = includes!(data, dataContext) as any;

		// if it's null, just leave it
		if (!response) return;

		// Setting the values
		const keys = Object.keys(response);
		forEach(keys, key => data[key] = response[key]);
	}

	private static applyIncludeArray<T>(
		dataContext: DataContext,
		data: any,
		includes?: IncludeExpression<T>
	) {
		forEach(data, (dt) => this.applyIncludeObject(dataContext, dt, includes));
	}

	static dispatch<T>(
		data: T,
		expression?: any
	) {
		if (!data) return data;

		if (!expression) return data;

		if ((data instanceof Array) || Array.isArray(data))
			this.applyIncludeArray(dataContext, data, expression);
		else
			this.applyIncludeObject(dataContext, data, expression);

		return data;
	}
}