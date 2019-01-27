import React, { Component } from 'react'

class SignIn extends Component {
    constructor(){
        super()
        this.state = {
            email: '',
            password: ''
        }
    }

    render() {
        return (
            <div>
                <input type='text' label='Email' value={this.state.email} onChange={(e) => this.setState({email: e.target.value})} />
                <input type='password' label='Password' value={this.state.password}  onChange={(e) => this.setState({password: e.target.value})} />
                <button onClick={() => this.props.signInWithGoogle()} label='Sign in with Google'>Sign in with Google</button>
                <button onClick={() => this.props.signInWithEmail(this.state.email, this.state.password)} label='Sign In'>Sign In</button>
                <button onClick={() => this.props.dejToken()} label="loguj sie!"> Dej</button>
                <button onClick={() => this.props.signOut()} label="Sign Out">Sign Out</button>
            </div>
        );
    }
}

export default SignIn
