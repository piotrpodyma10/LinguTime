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
            
            <div className='ui form'>
                <div className='field'>
                    <div className='ui left icon input'>
                        <i class='user icon'></i>
                        <input type='text' placeholder='Email' value={this.state.email} onChange={(e) => this.setState({email: e.target.value})} />
                    </div>
                </div>
                <div className='field'>
                    <div className='ui left icon input'>
                        <i class='lock icon'></i>
                        <input type='password' placeholder='Password' value={this.state.password}  onChange={(e) => this.setState({password: e.target.value})} />
                    </div>
                </div>
                <div className='field'>
                    <div className='ui left icon input'>
                        <i class='lock icon'></i>
                        <input type='password' placeholder='Repeat password' value={this.state.repeatPassword}  onChange={(e) => this.setState({repeatPassword: e.target.value})} />
                    </div>
                </div>
                <button className='ui button' onClick={() => this.props.createUser(this.state.email, this.state.password)} label='Sign Up'>
                    Sign Up
                </button>

                {/* <button onClick={() => this.props.createUser(this.state.email, this.state.password)} label='Sign Up'>Sign Up</button>
                <button onClick={() => this.props.createUserAndRetrieveData(this.state.email, this.state.password)} label='Sign Up'>Sign Up (/w result)</button> */}
            </div>
        );
    }
}

export default SignUp
