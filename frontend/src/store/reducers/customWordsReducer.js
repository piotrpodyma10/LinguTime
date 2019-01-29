export const fetchAllCustomWordsReducer = (state = [], action) => {
    switch (action.type) {
        case 'FETCH_ALL_CUSTOM_WORDS':
            return action.payload
        default:
            return state
    }
}

export const fetchCustomWordsByCategory = (state = [], action) => {
    switch (action.type) {
        case 'FETCH_CUSTOM_WORDS_BY_CATEGORY':
            return action.payload
        default:
            return state
    }
}

export const fetchCustomWordsMetadata = (state = [], action) => {
    switch (action.type) {
        case 'FETCH_CUSTOM_WORDS_METADATA':
            return action.payload
        default:
            return state
    }
}

// export const saveCustomWordMetadata = (state = [], action) => {
//     switch (action.type) {
//         case 'SAVE_CUSTOM_WORDS_METADATA':
//             return action.payload
//         default:
//             return state
//     }
// }

// export const saveCustomWord = (state = [], action) => {
//     switch (action.type) {
//         case 'SAVE_CUSTOM_WORD':
//             return action.payload
//         default:
//             return state
//     }
// }