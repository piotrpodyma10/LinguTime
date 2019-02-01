import React, { Component } from 'react'
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import SideNav, { Toggle, Nav, NavItem, NavIcon, NavText } from '@trendmicro/react-sidenav'
import '@trendmicro/react-sidenav/dist/react-sidenav.css'
import './mainSidebar.css'
import SelectMainLanguage from './SelectMainLanguage'
import SelectToLearnLanguage from './SelectToLearnLanguage'
import SelectCategory from './SelectCategory'
import FlashCards from './FlashCards'
import Chart from './Chart/Chart'

export default class MainSidebar extends Component {

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
                        }}>
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
                                        <div className="title">Log out</div>
                                    </NavText>
                                </NavItem>
                            </SideNav.Nav>
                        </SideNav>
                        <main>
                            {/* <Route path="/" exact component={} /> */}
                            <Route path="/home" component={SelectMainLanguage} />
                            <Route path="/statictics" component={Chart} />
                            <Route path="/languageToLearn" component={SelectToLearnLanguage} />
                            <Route path="/category" component={SelectCategory} />
                            <Route path="/flashCards" component={FlashCards} />
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