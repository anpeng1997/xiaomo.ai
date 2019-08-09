import { ADD, MINUS } from '../types/home'

export default () => {
    console.log("home reducer")
    const initialState = {
        num: -1
    }
    return function reducer(state = initialState, action) {
        console.log("Action type:" + action.type);
        switch (action.type) {
            case ADD:
                return Object.assign({}, state, { num: state.num + action.payload })
            case MINUS:
                return Object.assign({}, state, { num: state.num - action.payload })
            default:
                return state
        }
    }
}