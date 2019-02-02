import { SET_USER, SET_TOKEN, ADD_MESSAGE, REMOVE_MESSAGE } from '../actions/appActions'

export default (state = { user: null, credential: null, messages: [] }, action) => {
    switch (action.type) {
        case SET_USER:
            return {...state, user: action.payload}
        case SET_TOKEN:
            return {...state, token: action.payload}
        case ADD_MESSAGE:
            return {...state, messages: [...state.messages, action.payload]}
        case REMOVE_MESSAGE:
            return {...state, messages: [...state.messages.slice(0, action.payload), ...state.messages.slice(action.payload + 1)]}
        default:
            return state
    }
}