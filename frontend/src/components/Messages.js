import React, { Component } from 'react'
import { connect } from 'react-redux'
import { removeMessage } from '../store/actions/appActions'

class Messages extends Component {
    render() {
        return (
            <div style={{position: 'absolute', width: '100vw'}}>
                {
                    this.props.messages.map((message, index) => this.renderMessage(message, index))
                }
            </div>
        )
    }

    renderMessage(message, index){
        switch(message.type){
            case 'SUCCESS': return this.renderSuccess(message, index)
            case 'ERROR': return this.renderError(message, index)
            default: return this.renderNeutral(message, index)
        }
    }

    renderSuccess(message, index){
        setTimeout(() => this.props.discardMessage(index), 3000)
        return (
            <div class="ui green message">
                <i class="close icon" onClick={() => this.props.discardMessage(index)}></i>
                <div class="header{">
                    {message.header}
                </div>
                <p>{message.text}</p>
            </div>
        )
    }

    renderError(message, index){
        return (
            <div class="ui red message">
                <i class="close icon" onClick={() => this.props.discardMessage(index)}></i>
                <div class="header">
                    {message.header}
                </div>
                <p>{message.text}</p>
            </div>
        )
    }

    renderNeutral(message, index){
        setTimeout(() => this.props.discardMessage(index), 3000)
        return (
            <div class="ui message">
                <i class="close icon" onClick={() => this.props.discardMessage(index)}></i>
                <div class="header">
                    {message.header}
                </div>
                <p>{message.text}</p>
            </div>
        )
    }
}

const mapStateToProps = state => {
    return {
        messages: state.app.messages
    }
}

const mapDispatchToProps = dispatch => {
    return {
        discardMessage: (index) => dispatch(removeMessage(index)) 
    }
}

export default connect (mapStateToProps, mapDispatchToProps)(Messages)