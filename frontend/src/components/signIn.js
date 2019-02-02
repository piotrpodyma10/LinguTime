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
            <div className='ui form'>
                <div className='field'>
                    <div className='ui left icon input'>
                        <i className='user icon'></i>
                        <input type='text' placeholder='Email' value={this.state.email} onChange={(e) => this.setState({email: e.target.value})} />
                    </div>
                </div>
                
                <div className='field'>
                    <div className='ui left icon input'>
                        <i className='lock icon'></i>
                        <input type='password' placeholder='Password' value={this.state.password}  onChange={(e) => this.setState({password: e.target.value})} />
                    </div>
                </div>

                <button className='ui blue submit button' onClick={() => this.props.signInWithEmail(this.state.email, this.state.password)} label='Sign In'>
                    Sign In
                </button>
                
                <button className='ui google plus button' onClick={() => this.props.signInWithGoogle()} style={{marginTop: '16px'}}>
                    <i className='google plus icon'></i>
                    Sign in with Google
                </button>
            </div>
        );
    }
}

export default SignIn
