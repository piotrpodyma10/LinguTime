import { allFlashCards } from '../../models/flashCards'

export const fetchAllFlashCards = (mainLanguageId, languageToLearnId, categoryId) => async dispatch => {
    const response = await allFlashCards(mainLanguageId, languageToLearnId, categoryId)

    dispatch({ 
        type: 'FETCH_FLASH_CARDS', 
        payload: response 
    })
}