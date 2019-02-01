import { allLanguages, languageToLearn } from '../../models/languages'

export const fetchAllLanguages = () => async dispatch => {
    const response = await allLanguages()

    dispatch({ 
        type: 'FETCH_LANGUAGES', 
        payload: response 
    })
}

export const fetchLanguagesToLearn = (languageId) => async dispatch => {
    const response = await languageToLearn(languageId)

    dispatch({ 
        type: 'FETCH_LANGUAGES_TO_LEARN', 
        payload: response 
    })
}