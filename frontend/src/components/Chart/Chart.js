import React, { Component } from 'react'
import { connect } from 'react-redux'
import buildChart from './buildChart'
import { fetchUserPoints } from '../../store/actions'

class Chart extends Component {

    componentDidMount() {
        this.props.fetchUserPoints()
    }

    componentDidUpdate() {
        buildChart(this.props.category, this.props.scores)
    }

    render() {
        return (
            <div>
                <div style={{height:'30vh', display:'flex', justifyContent:'center', alignItems:'center', color:'white', fontSize:'25px'}}>
                    <div>
                        <span><i class="fas fa-chart-area" style={{fontSize:'25px', marginRight:'5px'}}></i></span><span>Check your statistics!</span>
                    </div>
                </div>
                <div style={{display:'flex', justifyContent:'center', alignItems:'top', height:'70vh'}}>
                    <div style={{width: '1200px', height:'500px'}}>
                        <canvas id="myChart" width='1200' height='500'></canvas>
                    </div>
                </div>
            </div>
        )
    }
}

const mapStateToProps = state => {
    return {
        scores: state.userPoints.scores,
        category: state.userPoints.category
    }
}

export default connect ( 
    mapStateToProps, {
        fetchUserPoints
    }
)(Chart)