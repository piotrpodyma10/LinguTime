import React, { Component } from 'react'
import { connect } from 'react-redux'
import { fetchLanguagesToLearn } from '../store/actions'
import { Link } from 'react-router-dom'

class SelectToLearnLanguage extends Component {

    componentDidMount() {
        this.props.fetchLanguagesToLearn(this.props.location.mainLanguage)
    }

    render() {
        return (
            <div>
                <div className="mainLanguageContainer">
                    <div className="mainLanguageTitle"><i class="fas fa-chess-pawn towerIcon"></i><span>What language you want to learn?</span><i class="fas fa-cat catIcon"></i></div>
                </div>
                <div className="allCountriesContainer">
                    {this.props.languageToLearn.map(language => {
                        return (
                            <Link 
                                to={{ pathname: '/category', languageToLearn: language.id, mainLanguage: this.props.location.mainLanguage}}
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
    console.log('State2', state)
    return {
        languageToLearn: state.languageToLearn,
        // allLanguages: state.languages
    }
}

export default connect ( 
    mapStateToProps, {
        fetchLanguagesToLearn
    }
)(SelectToLearnLanguage)