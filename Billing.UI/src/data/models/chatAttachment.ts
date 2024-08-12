import User from "./user"

export default interface ChatAttachment {
	id: string
	attachment: string
	
	chatMessageId: string
	createdAt: Date
}