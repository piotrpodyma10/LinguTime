import { fetchAllCategories } from '../../models/categories'


export const fetchAllCategories = () => async dispatch => {
    const response = await fetchAllCategories()

    dispatch({ 
        type: 'FETCH_CATEGORIES', 
        payload: response 
    })
}