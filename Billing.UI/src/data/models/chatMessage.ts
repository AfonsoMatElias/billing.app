import ChatAttachment from "./chatAttachment"
import User from "./user"

export default interface ChatMessage {
	id: string
	
	to: string
	from: string

	content: string
	chatAttachments: ChatAttachment[]
	createdAt: Date
}