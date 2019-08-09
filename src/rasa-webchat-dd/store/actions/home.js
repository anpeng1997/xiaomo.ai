import { ADD, MINUS } from '../types/home'

export const add = (count=1) => {
    return {
        type: ADD,
        payload: count
    }
}

export const minus = function (count) {
    return {
        type: MINUS,
        payload: count
    }
}