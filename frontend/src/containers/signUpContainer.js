import {connect} from 'react-redux'
import SignUp from '../components/signUp'
import { auth } from '../config/firebaseConfig'
import { addUser } from '../actions/actions'

const mapStateToProps = (state, ownProps) => {
    return {
    }
}

const mapDispatchToProps = (dispatch) => {
    return {
        createUser: (email, password) => auth.createUserWithEmailAndPassword(email, password)
                                                .then(result => {
                                                    dispatch(addUser(result.user.uid))
                                                }),
        createUserAndRetrieveData: (email, password) => auth.createUserAndRetrieveDataWithEmailAndPassword(email, password)
                                                .then(result => console.log(result))
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(SignUp)