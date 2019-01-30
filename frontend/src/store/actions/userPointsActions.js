import { userPoints } from '../../models/userPoints'

export const fetchUserPoints = () => async dispatch => {
    const response = await userPoints(1)

    dispatch({ 
        type: 'FETCH_USER_POINTS', 
        payload: response 
    })
}