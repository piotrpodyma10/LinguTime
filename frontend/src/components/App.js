import React from 'react'
import MainSidebar from './MainSidebar'
import Messages from './Messages';

const App = () => {
    return (
        <div style={{height: '100%'}}>
            <Messages />
            <MainSidebar />
        </div>
    )
}

export default App