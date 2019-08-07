export default interface IMessageResponse {
    recipient_id: string;
    text: string;
    image?: string;
    buttons?: Array<IButton>;
}

export interface IButton {
    title: string;
    payload: string;
}