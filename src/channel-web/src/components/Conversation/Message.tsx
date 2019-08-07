import * as React from 'react';
import Markdown from "react-markdown";
import breaks from 'remark-breaks'
import classNames from 'classnames';
import styles from 'Message.less'
import IMessage from '../../@types/IMessage';

export interface IMessageProps {
    message: IMessage
}

class Message extends React.PureComponent<IMessageProps> {
    render() {
        const { message } = this.props;
        const { username, type, text } = message;
        const isBot = username === 'bot';

        switch (type) {
            case 'text':
                return (
                    <div className={classNames(styles.chat, isBot ? styles.left : styles.right)}>
                        {
                            isBot ?
                                (
                                    <Markdown source={text}
                                        className={styles.text}
                                        skipHtml={false}
                                        renderers={{
                                            paragraph: ({ children }) => <span>{children}</span>,
                                            link: ({ href, children }) => (
                                                <a href={href} target="_blank">
                                                    {children}
                                                </a>
                                            )
                                        }}
                                        plugins={[breaks]} />
                                ) :
                                { text }
                        }
                    </div>
                )
            default:
                return null;
        }
    }
}

export default Message;