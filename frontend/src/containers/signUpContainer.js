import {connect} from 'react-redux'
import SignUp from '../components/signUp'
import { auth } from '../config/firebaseConfig'
import { addMessage, addUser } from '../store/actions/appActions'

const mapStateToProps = (state, ownProps) => {
    return {
    }
}

const mapDispatchToProps = (dispatch) => {
    return {
        createUser: (email, password) => auth.createUserWithEmailAndPassword(email, password)
                                                .then(result => {
                                                    dispatch(addUser(result.user.uid))
                                                }).catch(error => {
                                                    dispatch(addMessage('Login failed!', error.message, 'ERROR'))
                                                })
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(SignUp)