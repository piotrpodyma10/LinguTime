import React, { Component } from 'react'
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import SideNav, { Toggle, Nav, NavItem, NavIcon, NavText } from '@trendmicro/react-sidenav'
import '@trendmicro/react-sidenav/dist/react-sidenav.css'
import './mainSidebar.css'

export default class MainSidebar extends Component {

  render() {
    return (
        <Router>
            <Route render={({ location, history }) => (
                <React.Fragment >
                    <SideNav className="mainSidebar"
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
                                    <i class="fas fa-globe-americas" style={{ fontSize: '1.75em'}} />
                                </NavIcon>
                                <NavText>
                                    LinguTime
                                </NavText>
                            </NavItem>
                            <NavItem eventKey="home" className="sidebarElement">
                                <NavIcon>
                                    <i class="fas fa-book" style={{ fontSize: '1.75em' }} />
                                </NavIcon>
                                <NavText>
                                    Global words
                                </NavText>
                            </NavItem>
                            <NavItem eventKey="custom" className="sidebarElement">
                                <NavIcon>
                                    <i class="fas fa-user-circle" style={{ fontSize: '1.75em' }} />
                                </NavIcon>
                                <NavText>
                                    Custom words
                                </NavText>
                            </NavItem>
                            <NavItem eventKey="statictics" className="sidebarElement">
                                <NavIcon>
                                    <i class="fas fa-chart-line" style={{ fontSize: '1.75em' }} />
                                </NavIcon>
                                <NavText>
                                    Check your statistics
                                </NavText>
                            </NavItem>
                            <NavItem eventKey="logout" style={{position:'absolute', bottom: '0px', width: 'inherit'}} className="sidebarElement">
                                <NavIcon>
                                <i class="fas fa-sign-out-alt" style={{ fontSize: '1.75em' }} />
                                </NavIcon>
                                <NavText>
                                    Log out
                                </NavText>
                            </NavItem>
                        </SideNav.Nav>
                    </SideNav>
                    <main>
                        {/* <Route path="/" exact component={} />
                        <Route path="/home" component={} />
                        <Route path="/devices" component={} />
                        <Route path="*" component={NotFound} /> */}
                    </main>
                </React.Fragment>
            )}
            />
        </Router>
    )
  }
}