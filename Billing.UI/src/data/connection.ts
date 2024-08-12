import Authenticator from "./authenticator";
import DataContext from "./dataContext";
import storage from "./storage";

const dataContext = new DataContext(storage);
const authenticator = new Authenticator(dataContext);

export {
	authenticator, dataContext
};
