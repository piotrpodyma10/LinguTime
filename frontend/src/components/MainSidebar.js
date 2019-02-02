import React, { Component } from 'react'
import {connect} from 'react-redux'
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import SideNav, { Toggle, Nav, NavItem, NavIcon, NavText } from '@trendmicro/react-sidenav'
import '@trendmicro/react-sidenav/dist/react-sidenav.css'
import './mainSidebar.css'
import SelectMainLanguage from './SelectMainLanguage'
import SelectToLearnLanguage from './SelectToLearnLanguage'
import SelectCategory from './SelectCategory'
import FlashCards from './FlashCards'
import Chart from './Chart/Chart'
import Main from './Main'
import { auth } from '../config/firebaseConfig'
import { setUser, setToken } from '../store/actions/appActions'
import ProtectedRoute from './ProtectedRoute'

class MainSidebar extends Component {

    state = {
        expanded: false
    };

    onToggle = (expanded) => {
        this.setState({ expanded: expanded })
    }

    render() {
        return (
            <Router>
                <Route render={({ location, history }) => (
                    <React.Fragment >
                        <div
                        style={{
                            marginLeft: this.state.expanded ? 240 : 64,
                            padding: '0px 20px 0px 20px',
                            transition: '0.2s',
                            height: '100%'
                        }}>
                        {
                            this.props.token != null && this.props.token != '' && 
                            <SideNav className="mainSidebar" onToggle={this.onToggle}
                                onSelect={(selected) => {
                                    const to = '/' + selected;
                                    if (location.pathname !== to) {
                                        history.push(to);
                                    }
                                }}
                            >
                                <SideNav.Toggle />
                                <SideNav.Nav defaultSelected="home">
                                    <NavItem disabled>
                                        <NavIcon>
                                            <i class="fas fa-globe-americas mainIcon" style={{ fontSize: '1.75em'}} />
                                        </NavIcon>
                                        <NavText>
                                            <div className="title">LinguTime</div>
                                        </NavText>
                                    </NavItem>
                                    <NavItem eventKey="home" className="sidebarElement">
                                        <NavIcon>
                                            <i class="fas fa-book mainIcon" style={{ fontSize: '1.75em' }} />
                                        </NavIcon>
                                        <NavText>
                                            <div className="title">Global words</div>
                                        </NavText>
                                    </NavItem>
                                    <NavItem eventKey="custom" className="sidebarElement">
                                        <NavIcon>
                                            <i class="fas fa-user-circle mainIcon" style={{ fontSize: '1.75em' }} />
                                        </NavIcon>
                                        <NavText>
                                            <div className="title">Custom words</div>
                                        </NavText>
                                    </NavItem>
                                    <NavItem eventKey="statictics" className="sidebarElement">
                                        <NavIcon>
                                            <i class="fas fa-chart-line mainIcon" style={{ fontSize: '1.75em' }} />
                                        </NavIcon>
                                        <NavText>
                                            <div className="title">Check your statistics</div>
                                        </NavText>
                                    </NavItem>
                                    <NavItem eventKey="logout" style={{position:'absolute', bottom: '0px', width: 'inherit'}} className="sidebarElement">
                                        <NavIcon>
                                        <i class="fas fa-sign-out-alt mainIcon" style={{ fontSize: '1.75em' }} />
                                        </NavIcon>
                                        <NavText>
                                            <div className="title" onClick={() => this.props.signOut()}>Log out</div>
                                        </NavText>
                                    </NavItem>
                                </SideNav.Nav>
                            </SideNav>
                        }
                        <main style={{height: '100%'}}>
                            <Route path="/" exact component={Main} />
                            <ProtectedRoute path="/home" component={SelectMainLanguage} token={this.props.token} />
                            <ProtectedRoute path="/statictics" component={Chart}  token={this.props.token} />
                            <ProtectedRoute path="/languageToLearn" component={SelectToLearnLanguage}  token={this.props.token} />
                            <ProtectedRoute path="/category" component={SelectCategory}  token={this.props.token} />
                            <ProtectedRoute path="/flashCards" component={FlashCards}  token={this.props.token} />
                            {/* <Route path="*" component={NotFound} />  */}
                        </main>
                        </div>
                    </React.Fragment>
                )}
                />
            </Router>
        )
    }
}

const mapStateToProps = state => {
    return {
        token: state.app.token
    }
}

const mapDispatchToProps = dispatch => {
    return {
        signOut: () => {
            auth.signOut()
            dispatch(setUser(null))
            dispatch(setToken(null))
        }
    }
}

export default connect (mapStateToProps, mapDispatchToProps)(MainSidebar)