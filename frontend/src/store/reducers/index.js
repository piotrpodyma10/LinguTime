import { combineReducers } from 'redux'
import {
    fetchAllCategoriesReducer,
    fetchCategoryByIdReducer
} from './categoriesReducer'
import {
    fetchAllCustomWordsReducer,
    fetchCustomWordsByCategory,
    fetchCustomWordsMetadata
} from './customWordsReducer'
import {
    fetchAllLanguagesReducer,
    fetchLanguageToLearnReducer
} from './languagesReducer'
import {
    fetchUserPointsReducer
} from './userPointsReducer'
import {
    fetchAllWordsReducer,
    fetchWordsByCategory
} from './wordsReducer'
import {
    fetchAllFlashCardsReducer
} from './flashCardsReducer'
import appReducer from './appReducer'

export default combineReducers({
    categories: fetchAllCategoriesReducer,
    category: fetchCategoryByIdReducer,
    customWords: fetchAllCustomWordsReducer,
    customWord: fetchCustomWordsByCategory,
    customWordsMetadata: fetchCustomWordsMetadata,
    languages: fetchAllLanguagesReducer,
    languageToLearn: fetchLanguageToLearnReducer,
    userPoints: fetchUserPointsReducer,
    words: fetchAllWordsReducer,
    wordsByCategory: fetchWordsByCategory,
    flashCards: fetchAllFlashCardsReducer,
    app: appReducer
})