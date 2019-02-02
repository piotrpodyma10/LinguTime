import React, { Component } from 'react'
import { Link } from 'react-router-dom'

class DisplayCountries extends Component {

    render() {
        return (
            <div>
                <div className="mainLanguageContainer">
                    <div className="mainLanguageTitle"><i class="fas fa-chess-rook towerIcon"></i><span>{this.props.mainText}</span><i class="fas fa-dragon dragonIcon"></i></div>
                </div>
                <div className="allCountriesContainer">
                    {this.props.allLanguages.map(language => {
                        return (
                            <Link 
                                to={{ pathname: `${this.props.pathname}`, this.props.property: language.id}}
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

export default DisplayCountries