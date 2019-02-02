import React, { Component } from 'react'
import { connect } from 'react-redux'
import { fetchAllCategories } from '../store/actions'
import { Link } from 'react-router-dom'

class SelectCategory extends Component {

    componentDidMount() {
        this.props.fetchAllCategories()
    }

    render() {
        return (
            <div>
                <div className="mainLanguageContainer">
                    <div className="mainLanguageTitle"><i class="fas fa-dice towerIcon"></i><span>Please choose any category</span><i class="fas fa-paw catIcon"></i></div>
                </div>
                <div className="allCategoriesContainer">
                    {this.props.categories.map(category => {
                        return (
                            <Link 
                                to={{ pathname: '/flashCards', category: category.id, languageToLearn: this.props.location.languageToLearn, mainLanguage: this.props.location.mainLanguage}}
                            >
                            <div className="categoryContainer">
                                <img className="categoryImg" src={category.img}>
                                </img>
                                <div className="categoryTitle">{category.name}</div>
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
        categories: state.categories,
        // allLanguages: state.languages
    }
}

export default connect ( 
    mapStateToProps, {
        fetchAllCategories
    }
)(SelectCategory)