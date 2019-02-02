import { putUser } from '../../api/api'
import { auth } from '../../config/firebaseConfig'

export const addUser = (userId) => {
    return (dispatch) => {
        return putUser(userId).then(result => {
            dispatch(addMessage('Success!', 'User created!', 'SUCCESS'))
        })
    }
}

export const SET_USER = 'SET_USER'

export const setUser = (user) => {
    return {
        type: SET_USER,
        payload: user
    }
}

export const SET_TOKEN = 'SET_TOKEN'

export const setToken = (token) => {
    return {
        type: SET_TOKEN,
        payload: token
    }
}

export const ADD_MESSAGE = 'ADD_MESSAGE'

export const addMessage = (header, message, type) => {
    return {
        type: ADD_MESSAGE,
        payload: {header, message, type}
    }
}

export const REMOVE_MESSAGE = 'REMOVE_MESSAGE'

export const removeMessage = (index) => {
    return {
        type: REMOVE_MESSAGE,
        payload: index
    }
}