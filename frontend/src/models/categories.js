import axios from 'axios'
import { BASE_URL } from '../utils/constans'

export const fetchAllCategories = async () => {
    const result = []    
    await axios.get(`${BASE_URL}/Categories`)
        .then(categories => {
            result.push(categories)
        }).catch((e) => {
            console.log(e)
        })

    return await result 
}