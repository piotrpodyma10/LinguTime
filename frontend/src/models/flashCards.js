import axios from 'axios'
import { BASE_URL } from '../utils/constans'

export const allFlashCards = async (mainLanguageId, languageToLearnId, categoryId) => {
    let result   
    await axios.get(`${BASE_URL}/Flash-Cards?mainLanguageId=${mainLanguageId}&languageToLearnId=${languageToLearnId}&categoryId=${categoryId}`)
        .then(flashCards => {
            result = flashCards.data
        }).catch((e) => {
            console.log(e)
        })

    return await result 
}