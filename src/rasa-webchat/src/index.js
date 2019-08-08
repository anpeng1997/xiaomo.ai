import React from 'react';
import PropTypes from 'prop-types';
import { Provider } from 'react-redux';
import { store, initStore } from './store/store';
import Widget from './components/widget'

class ConversationWidget extends React.PureComponent {
    static defaultProps = {
        title: "mo.ai Chat"
    }

    componentWillMount() {
        const { params = {} } = this.props;
        const storage = params.storage === 'session' ? sessionStorage : localStorage;
        initStore(storage);
    }

    render() {
        return (
            <Provider store={store}>
                <Widget {...this.props} />
            </Provider>
        )
    }
}

ConversationWidget.propTypes = {
    title: PropTypes.string,
}

export default ConversationWidget;