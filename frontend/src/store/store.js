import { createStore, applyMiddleware, compose } from "redux"
import rootReducer from "../reducers/rootReducer"
import thunk from "redux-thunk"

const middlewares = [thunk]

const { logger } = require('redux-logger')
middlewares.push(logger)

const store = createStore(
    rootReducer,
    applyMiddleware(...middlewares)
)

export default store