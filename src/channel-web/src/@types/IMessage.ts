import IMessageResponse from './IMessageResponse';

export default interface IMessage extends IMessageResponse {
    username: string;
    type: string;
}