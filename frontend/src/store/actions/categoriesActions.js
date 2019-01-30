import { allCategories } from '../../models/categories'

export const fetchAllCategories = () => async dispatch => {
    const response = await allCategories()

    dispatch({ 
        type: 'FETCH_CATEGORIES', 
        payload: response 
    })
}