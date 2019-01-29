export const fetchUserPointsReducer = (state = [], action) => {
    switch (action.type) {
        case 'FETCH_USER_POINTS':
            return action.payload
        default:
            return state
    }
}

// export const saveUserPointsReducer = (state = [], action) => {
//     switch (action.type) {
//         case 'SAVE_USER_POINTS':
//             return action.payload    
//         default:
//             return state
//     }
// }