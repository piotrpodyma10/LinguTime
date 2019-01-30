import axios from 'axios'
import { BASE_URL } from '../utils/constans'

export const allCategories = async () => {
    let result   
    await axios.get(`${BASE_URL}/Categories`)
        .then(categories => {
            result = categories
        }).catch((e) => {
            console.log(e)
        })

    return await result 
}