export const fetchAllWordsReducer = (state = [], action) => {
    switch (action.type) {
        case 'FETCH_ALL_WORDS':
            return action.payload
        default:
            return state
    }
}

export const fetchWordsByCategory = (state = [], action) => {
    switch (action.type) {
        case 'FETCH_WORDS_BY_CATEGORY':
            return action.payload
        default:
            return state
    }
}