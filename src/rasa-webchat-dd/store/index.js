import { createStore, combineReducers } from '../lib/redux/redux'
import home from './reducers/home'


export default () => {
    const reducer = combineReducers({
        // behavior: behavior(hintText, connectingText, storage, docViewer),
        home: home()
    });

    return createStore(reducer);
}
