import React, { Component } from 'react'
import { connect } from 'react-redux'
import { Link } from 'react-router-dom'
import SignInContainer from '../containers/signInContainer'
import SignUpContainer from '../containers/signUpContainer'

class Main extends Component {

    render() {
        return (
            <div style={{height:'100%', width:'100%', background: 'linear-gradient(rgba(0, 0, 0, 0.6), rgba(0, 0, 0, 0.3)),url(https://tvzg.pl/wp-content/uploads/2018/06/szkola-tablica.jpg) no-repeat center center fixed'}}> 
                    {
                        this.props.token == null || this.props.token == '' ?
                        <div class="ui placeholder segment" style={{top: '30%', marginLeft: '10%', marginRight: '10%'}}>
                            <div>
                                <div class="ui two column very relaxed stackable grid">
                                    <div class="column">
                                        <SignInContainer />
                                    </div>
                                    <div class="middle aligned column">
                                        <SignUpContainer />
                                    </div>
                                </div>
                                <div class="ui vertical divider">
                                    Or
                                </div> 
                            </div>
                        </div>
                        :
                        <div class="ui placeholder segment" style={{top: '30%', marginLeft: '10%', marginRight: '10%'}}>
                            <div class="ui icon header">
                            <i class="pdf file outline icon"></i>
                            No documents are listed for this customer.
                            </div>
                            <div class="ui primary button">Add Document</div>
                        </div>
                    }
            </div>
        )
    }
}

export default Main