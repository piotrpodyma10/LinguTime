import { putUser } from '../api/api'
import { auth } from '../config/firebaseConfig'

export const addUser = (userId) => {
    return (dispatch) => {
        return putUser(userId).then(result => {
            dispatch(addUserSuccess())
        })
    }
}

export const ADD_USER_SUCCESS = 'ADD_USER_SUCCESS'
export const addUserSuccess = () => {
    return {
        type: ADD_USER_SUCCESS
    }
}