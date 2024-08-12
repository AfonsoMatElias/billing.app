import ChatMessage from "./chatMessage";
import User from "./user";

export default interface Chat {
	id: string;
	code: string;
	creatorId: string;
	creator?: User;

	invitedId: string;
	invited?: User;

	messages: ChatMessage[]
	createAt: Date
}