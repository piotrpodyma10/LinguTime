import Chart from 'chart.js'

export default (labels, data) => {
    const ctx = document.getElementById("myChart").getContext('2d');
    const myChart = new Chart(ctx, {
        type: 'bar',
        data: {
            labels: labels,
            datasets: [{
                label: 'Result of learning per category',
                data: data,
                backgroundColor: 'rgb(124, 252, 0, 0.6)',
                borderColor: 'rgb(124, 252, 0, 1)',
                borderWidth: 2
            }]
        },
        options: {
            scales: {
                yAxes: [{
                    ticks: {
                        beginAtZero:true,
                        fontColor : "white",
                        fontSize : 14,
                        max: 100,
                    },
                    gridLines:{
                        color: 'rgba(255, 167, 0, 0.6)',
                        lineWidth:2,
                        zeroLineColor :"white",
                        zeroLineWidth : 2
                      },
                }],
                xAxes: [{
                    ticks:{
                      fontColor : "white",
                      fontSize : 14
                    },
                    gridLines:{
                      lineWidth:2
                    }}]
            },
            legend: {
                labels: {
                    fontColor: 'white',
                    defaultFontSize: '50',
                    borderColor: '#000000',
                    fontSize:16
                }
            }
        }
    })
}