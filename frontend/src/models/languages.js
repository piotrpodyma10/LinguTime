import axios from 'axios'
import { BASE_URL } from '../utils/constans'

export const allLanguages = async () => {
    let result = {}

    await axios.get(`${BASE_URL}/Languages`)
        .then(languages => {
            // for(let i=0; i<languages.data.length; i++) {
            //     if(languages.data[i].name === 'English') {
            //         languages.data[i].img = 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTn1k4g7WJVd6LSjnDi02_7HSLMDDhteensvVxUSHEq5bzcVPw2lA'
            //     } else if (languages.data[i].name === 'Polish') {
            //         languages.data[i].img = 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS32f98_MjrQGbAukbUDwfX2GcUFn9Kk-9cCrVnexz4cn2M-cTC'
            //     } else if (languages.data[i].name === 'German') {
            //         languages.data[i].img = 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS3yY9SIKGo90E0RN6gQZqvufwIbqwgDbxwoz4lnWqyrPGRvp8j'
            //     } else if (languages.data[i].name === 'Spanish') {
            //         languages.data[i].img = 'data:image/png;base64,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'
            //     }
            // }
            result = languages.data
        }).catch((e) => {
            console.log(e)
        })

    return await result 
}

export const languageToLearn = async (languageId) => {
    let result

    await axios.get(`${BASE_URL}/Language-To-Learn?languageId=${languageId}`)
        .then(languages => {
            result = languages.data
        }).catch((e) => {
            console.log(e)
        })

    return await result 
}