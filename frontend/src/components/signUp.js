import React, { Component } from 'react'

class SignUp extends Component {
    constructor(){
        super()
        this.state = {
            email: '',
            password: '',
            repeatPassword: ''
        }
    }

    render() {
        return (
            <div>
                <input type='text' label='Email' value={this.state.email} onChange={(e) => this.setState({email: e.target.value})} />
                <input type='password' label='Password' value={this.state.password}  onChange={(e) => this.setState({password: e.target.value})} />
                <input type='password' label='Repeat password' value={this.state.repeatPassword}  onChange={(e) => this.setState({repeatPassword: e.target.value})} />

                <button onClick={() => this.props.createUser(this.state.email, this.state.password)} label="Sign Up">Sign Up</button>
                <button onClick={() => this.props.createUserAndRetrieveData(this.state.email, this.state.password)} label="Sign Up">Sign Up (/w result)</button>
            </div>
        );
    }
}

export default SignUp
