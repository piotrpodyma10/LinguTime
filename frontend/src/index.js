import React from 'react'
import ReactDOM from 'react-dom'
import { Provider } from 'react-redux'
import { createStore, applyMiddleware } from 'redux'
import reducers from './store/reducers'
import thunk from 'redux-thunk'
import App from './components/App'

const middlewares = [thunk]
const { logger } = require('redux-logger')
middlewares.push(logger)

const store = createStore(reducers, applyMiddleware(...middlewares))

ReactDOM.render(
    <Provider store={store}>
        <App />
    </Provider>,
    document.querySelector('#root')
)