export const fetchAllFlashCardsReducer = (state = [], action) => {
    switch (action.type) {
        case 'FETCH_FLASH_CARDS':
            return action.payload
        default:
            return state
    }
}