import {connect} from 'react-redux'
import SignIn from '../components/signIn'
import { auth, googleProvider } from '../config/firebaseConfig'

const mapStateToProps = (state, ownProps) => {
    return {
    }
}

const mapDispatchToProps = (dispatch) => {
    return {
        signInWithGoogle: () => {
            auth.signInWithPopup(googleProvider)
                .then(result => console.log(result))
        },
        signInWithEmail: (email, password) => {
            auth.signInWithEmailAndPassword(email, password)
                .then(result => console.log(result))
        },
        dejToken: () => auth.currentUser.getIdToken(/* forceRefresh */ true).then(token => console.log(token)),
        signOut: () => auth.signOut()
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(SignIn)