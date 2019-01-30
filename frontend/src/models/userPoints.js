import axios from 'axios'
import { BASE_URL } from '../utils/constans'

export const userPoints = async (userId) => {
    let result = {}
    const scores = []
    const category = []   
    await axios.get(`${BASE_URL}/UserPoints-By-UserId?userId=${userId}`)
        .then(userPoints => {
            for(let i=0; i<userPoints.data.length; i++) {
                category.push(userPoints.data[i].category.name)
                scores.push(userPoints.data[i].score)
            }
        }).catch((e) => {
            console.log(e)
        })
    result.scores = scores
    result.category = category

    return await result 
}