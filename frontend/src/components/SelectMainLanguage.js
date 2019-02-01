import React, { Component } from 'react'
import { connect } from 'react-redux'
import { fetchAllLanguages } from '../store/actions'
import { Link } from 'react-router-dom'

class SelectMainLanguage extends Component {

    componentDidMount() {
        this.props.fetchAllLanguages()
    }

    render() {
        return (
            <div>
                <div className="mainLanguageContainer">
                    <div className="mainLanguageTitle"><i class="fas fa-chess-rook towerIcon"></i><span>What is your main language?</span><i class="fas fa-dragon dragonIcon"></i></div>
                </div>
                <div className="allCountriesContainer">
                    {this.props.allLanguages.map(language => {
                        return (
                            <Link 
                                to={{ pathname: '/languageToLearn', mainLanguage: language.id}}
                            >
                            <div className="countryContainer">
                                <img className="flag" src={language.img}>
                                </img>
                                <div className="languageTitle">{language.name}</div>
                            </div>
                            </Link>
                        )
                    })}
                </div>
            </div>
        )
    }
}

const mapStateToProps = state => {
    return {
        allLanguages: state.languages
    }
}

export default connect ( 
    mapStateToProps, {
        fetchAllLanguages
    }
)(SelectMainLanguage)