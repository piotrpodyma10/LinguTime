import axios from 'axios'

const BASE_URL = 'https://localhost:5001/api/'

export const putUser = (userId) => {
    return axios.post(BASE_URL + 'Users/AddUser', { Id: userId} )
}
