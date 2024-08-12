import { Component } from "bouerjs";

import html from './chat.html';
import Chat from "../../../data/models/chat";
import ChatMessage from "../../../data/models/chatMessage";
import { getAchronym, toCode, toObject } from "../../../helpers/utils";
import { authenticator } from "../../../data/connection";
import UserModel from "../../../data/models/view/userModel";
import User from "../../../data/models/user";

export default class ChatComponent extends Component {
	readonly title = 'Chat';
	readonly route = '/chat';
	selectedChatElement?: Element;

	readonly data = {
		ref: 'AFONSOMATELIAS', // The logged user Id
		loadingMessages: false,
		chats: new Array<Chat>(),
		onlineUsers: [],
		messages: new Array<ChatMessage>(),
		selectedChat: toObject<Chat>(),

		typedContent: '',
	};

	constructor() {
		super(html);
	}

	loaded(): void {
		const bouer = this.bouer!;
		const data = bouer.data;
		data.currentPage = 'Chat';

		bouer.$routing.markActiveAnchor(bouer.el!.querySelector('.chat-link')!);

		if (bouer.data.showConversation)
			bouer.data.showConversation = false;

		this.data.ref = bouer.globalData.user.id;

		const user1 = authenticator.repo().findById('AFONSOMATELIAS', (row, dc) => {
			return {
				employee: dc.employee.find(x => x.userId == row.id, (e) => {
					return { store: dc.store.findById(e.storeId!) }
				})
			} as any;
		}) as UserModel;
		const user2 = authenticator.repo().findById('HACHRISS', (row, dc) => {
			return {
				employee: dc.employee.find(x => x.userId == row.id, (e) => {
					return { store: dc.store.findById(e.storeId!) }
				})
			} as any;
		}) as UserModel;

		this.data.chats = [
			{
				id: toCode(),
				code: toCode(),
				creatorId: user1.id,
				creator: user1,
				invitedId: user2.id,
				invited: user2,
				createAt: new Date('2024-03-21'),
				messages: [
					{
						id: toCode(),
						chatAttachments: [],
						content: 'Koroa, qual é a ideia kota!?',
						createdAt: new Date('2024-03-22'),
						from: user1.id,
						to: user2.id,
					},
					{
						id: toCode(),
						chatAttachments: [],
						content: 'Como estão indo as cenas?',
						createdAt: new Date('2024-03-22'),
						from: user1.id,
						to: user2.id,
					},
					{
						id: toCode(),
						chatAttachments: [],
						content: 'Numéiras... só você?',
						createdAt: new Date('2024-03-22'),
						from: user2.id,
						to: user1.id,
					},
				],
			}
		];
	}

	// Methods
	showPanel(evt: CustomEvent, prop: string) {
		const container = this.el as HTMLDivElement;
		container.querySelector('.hiddable-panel-' + prop)!
			.classList.add('show-' + prop);
	}

	messageResume(chat: Chat) {
		const message = chat.messages[0];
		if (!message) return;

		let content = message.content || '';
		const limit = 28;

		if (content.length >= limit)
			content = content.substring(0, limit) + '...';

		if (message.from == this.data.ref)
			content = 'Você: ' + content;

		return content;
	};

	selectChat(evt: CustomEvent, chat: Chat) {
		const cls = 'is-selected';

		if (this.selectedChatElement) {
			this.selectedChatElement.classList.remove(cls);
		}

		this.selectedChatElement = evt.currentTarget as Element;
		this.selectedChatElement!.classList.add(cls);
		this.data.selectedChat = JSON.parse(JSON.stringify(chat));

		this.data.messages = chat.messages;
	};

	sendMessage() {
		const typedContent = this.data.typedContent.trim();
		const attachments = [{}];
		if (!typedContent && attachments.length == 0) return;

		this.data.typedContent = '';

		this.data.messages.push({
			id: "undefined",
			to: "0001",
			from: "0002",
			content: typedContent,
			chatAttachments: [],
			createdAt: new Date()
		});
	};

	getMessageAchronym(message: ChatMessage) {
		const chat = this.data.selectedChat;
		const chatUsers: { [k: string]: UserModel | undefined } = {
			[chat.creatorId]: chat.creator,
			[chat.invitedId]: chat.invited,
		}

		const user = chatUsers[message.from];

		return getAchronym([user?.employee?.firstName, user?.employee?.lastName].join(' '));
	}

	onCtrlEnter(evt: any) {
		if ((evt.keyCode == 10 || evt.keyCode == 13) && evt.ctrlKey)
			this.sendMessage();
	}
}