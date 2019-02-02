import {connect} from 'react-redux'
import SignIn from '../components/signIn'
import { auth, googleProvider } from '../config/firebaseConfig'
import { setToken, setUser, addMessage } from '../store/actions/appActions';

const mapStateToProps = (state, ownProps) => {
    return {
    }
}

const mapDispatchToProps = (dispatch) => {
    return {
        signInWithGoogle: () => {
            auth.signInWithPopup(googleProvider)
                .then(result => {
                    dispatch(setUser(result.user))
                    auth.currentUser.getIdToken(true).then(token => {
                        dispatch(setToken(token))
                        dispatch(addMessage('Hello!', '', 'SUCCESS'))
                    })
                }).catch(error => {
                    dispatch(addMessage('Login failed!', error.message, 'ERROR'))
                })
        },
        signInWithEmail: (email, password) => {
            auth.signInWithEmailAndPassword(email, password)
                .then(result => {
                    dispatch(setUser(result.user))
                    auth.currentUser.getIdToken(true).then(token => {
                        dispatch(setToken(token))
                        dispatch(addMessage('Hello!', '', 'SUCCESS'))
                    })
                }).catch(error => {
                    dispatch(addMessage('Login failed!', error.message, 'ERROR'))
                })
        }
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(SignIn)