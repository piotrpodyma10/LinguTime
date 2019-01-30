import React from 'react'
import ReactDOM from 'react-dom'
import { Provider } from 'react-redux'
import { createStore, applyMiddleware } from 'redux'
import reducers from './store/reducers'
import thunk from 'redux-thunk'
import MainSidebar from './components/MainSidebar'

const store = createStore(reducers, applyMiddleware(thunk))

ReactDOM.render(
    <Provider store={store}>
        <MainSidebar />
    </Provider>,
    document.querySelector('#root')
)