import { allLanguages } from '../../models/languages'

export const fetchAllLanguages = () => async dispatch => {
    const response = await allLanguages()

    dispatch({ 
        type: 'FETCH_LANGUAGES', 
        payload: response 
    })
}