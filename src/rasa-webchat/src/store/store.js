
import { createStore, combineReducers, applyMiddleware } from "redux";
import messages from './reducers/messagesReducer'

let store = {};

function initStore(storage) {
    const reducer = combineReducers({
        // behavior: behavior(hintText, connectingText, storage, docViewer),
        messages: messages(storage)
    });

    /* eslint-disable no-underscore-dangle */
    store = createStore(
        reducer,
        window.__REDUX_DEVTOOLS_EXTENSION__ &&
        window.__REDUX_DEVTOOLS_EXTENSION__()
    );
    /* eslint-enable */
}

export { initStore, store };