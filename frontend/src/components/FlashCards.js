import React, { Component } from 'react'
import { connect } from 'react-redux'
import { fetchAllFlashCards } from '../store/actions'
import { Link } from 'react-router-dom'

class FlashCards extends Component {

    componentDidMount() {
        this.props.fetchAllFlashCards(this.props.location.mainLanguage, this.props.location.languageToLearn, this.props.location.category)
        console.log('ff', this.props.flashCards)
    }

    render() {
        console.log('return', this.props.flashCards)
        // console.log('return2', this.props.flashCards.flashCards[0])
        return (
            <div>
                <div className="mainLanguageContainer">
                    <div className="mainLanguageTitle"><i class="fas fa-dice towerIcon"></i><span>{this.props.flashCards.categoryName}</span><i class="fas fa-paw catIcon"></i></div>
                    <div className="mainLanguageTitle"><i class="fas fa-dice towerIcon"></i><span>Number of cards: {this.props.flashCards.numberOfWords}</span><i class="fas fa-paw catIcon"></i></div>
                </div>
                <div className="allCategoriesContainer">
                    {/* {this.props.flashCards.flashCards[0].map(flashCard => {
                        return (
                            <Link 
                                to={{ pathname: '/flashCards'}}
                            >
                            <div className="categoryContainer">
                                <img className="categoryImg" src={flashCard.img}>
                                </img>
                                <div className="categoryTitle">{flashCard.wordName}</div>
                            </div>
                            </Link>
                        )
                    })} */}
                </div>
            </div>
        )
    }
}

const mapStateToProps = state => {
    console.log('Statedada2', state)
    return {
        flashCards: state.flashCards
    }
}

export default connect ( 
    mapStateToProps, {
        fetchAllFlashCards
    }
)(FlashCards)