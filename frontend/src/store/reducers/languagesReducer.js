export const fetchAllLanguagesReducer = (state = [], action) => {
    switch (action.type) {
        case 'FETCH_LANGUAGES':
            return action.payload
        default:
            return state
    }
}

export const fetchLanguageToLearnReducer = (state = [], action) => {
    switch (action.type) {
        case 'FETCH_LANGUAGES_TO_LEARN':
            return action.payload
        default:
            return state
    }
}