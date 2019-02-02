import React, { Component } from 'react'
import logo from './logo.svg'
import './App.css'
import SignInContainer from './containers/signInContainer'
import SignUpContainer from './containers/signUpContainer'

class App extends Component {
  render() {
    return (
      <div className="App">
        <SignInContainer />
        <SignUpContainer />
      </div>
    );
  }
}

export default App;
