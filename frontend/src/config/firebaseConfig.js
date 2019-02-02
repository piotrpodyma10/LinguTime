import firebase from "firebase"

var config = {
    apiKey: "AIzaSyBXzyqf9er_Wi7tVI6N3VH04Tq-1RI8E9U",
    authDomain: "lingu-time.firebaseapp.com",
    databaseURL: "https://lingu-time.firebaseio.com",
    projectId: "lingu-time",
    storageBucket: "lingu-time.appspot.com",
    messagingSenderId: "80176453824"
}

firebase.initializeApp(config)

export const googleProvider = new firebase.auth.GoogleAuthProvider();
export const auth = firebase.auth();
export default firebase  