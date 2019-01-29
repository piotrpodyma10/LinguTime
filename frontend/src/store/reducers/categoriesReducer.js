export const fetchAllCategoriesReducer = (state = [], action) => {
    switch (action.type) {
        case 'FETCH_CATEGORIES':
            return action.payload
        default:
            return state
    }
}

export const fetchCategoryByIdReducer = (state = [], action) => {
    switch (action.type) {
        case 'FETCH_CATEGORY_BY_ID':
            return action.payload
        default:
            return state
    }
}

// export const saveCategoryReducer = (state = [], action) => {
//     switch (action.type) {
//         case 'SAVE_CATEGORY':
//             return action.payload
//         default:
//             return state
//     }
// }