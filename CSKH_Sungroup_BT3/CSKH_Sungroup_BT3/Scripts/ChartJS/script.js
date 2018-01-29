var myChart = {
  labels: ["Jan", "Feb", "Mar", "Apr", "May", "June"],
    datasets: [
      {
        label: 'Salary - 1',
        data: [10, -20, 50, 30, -60, 80],
        backgroundColor: '#ff8080',
        borderColor: '#ff8080',
        fill: false
      },
      { label: 'Salary - 2',
        data: [-50, 20, -10, 30, 80, 40],
        backgroundColor: '#80ffaa',
        borderColor: '#80ffaa',
        fill: false
    }
    ]
}
  var dataPieChart = {
    labels: ['Data-1,', 'Data-2', 'Data-3', 'Data-4', 'Data-5'],
      datasets: [{
        data: [10, 25, 20, 30, 15],
        backgroundColor: ['#ff8533', '#ffff33', '#33adff', '#39e600', '#bf8040']
      }]
  }
  window.onload = function() {
    // Bar Chart
    var barChart = document.getElementById('bar-chart').getContext("2d");
        myBar = new Chart(barChart,{
          type: 'bar',
          data: myChart,
          options:{
            title: {
              display: true,
              text: 'Bar Chart'
            }, 
            scales: {
              yAxes: [{
                ticks: {
                  beginAtZero: true,
                  max: 100
                }
              }]
            }
          }
        })

    // Bar Chart (horizontal bar)
    var horChart = document.getElementById('horizontal-chart').getContext("2d");
    myhorChart = new Chart(horChart,{
      type: 'horizontalBar',
      data: myChart,
      options:{
        title: {
          display: true,
          text: 'Horizontal Chart'
        },
        scales: {
          xAxes: [{
            ticks: {
              beginAtZero: true,
              max: 100
            }
          }]
        }
      }
    })
    //  Line Chart Multi - Axis
    var lineChart = document.getElementById('line-chart').getContext("2d");
    myLine = new Chart(lineChart, {
      type: 'line',
      data: myChart,
      options: {
        responsive: true,
        title: {
          display: true,
          text: 'Line Chart - Multi Axis'
        },
        scales: {
          yAxes: [{
            ticks: {
              beginAtZero: true, // value will be 0
              max: 100
            }
          },
            {
              position: 'right',
              id: 'y-axist-2',
            }
            ]
        }
      }
    });

    // Pie Chart
    var pieChart = document.getElementById('pie-chart').getContext('2d');
    myPie = new Chart(pieChart, {
      type: 'pie',
      data: dataPieChart,
      options: {
        responsive: true,
        title: {
          display: true,
          text: 'Pie Chart'
        }
      }
    });
  }
  //Get random color
  function getRandomColor() {
    var char = '0123456789ABCDEF';
    var color = '#';
    for (var i = 0; i < 6; i++) {
      color += char[Math.floor(Math.random() * 16)];
    }
    return color;
  }

  function getRandomNumber(){
    var number = Math.floor(Math.random() * 100 + 1);
    return number;
  }
  

  // Add Dataset Vertical chart

  function addDataVetical(){
    var colorName = getRandomColor();
    var newDS = {
      label: 'Salary - ' + (myChart.datasets.length + 1) ,
      backgroundColor: colorName,
      borderColor: colorName,
      data: []
    }

    for (var i = 0; i < myChart.labels.length; i++){
      newDS.data.push(getRandomNumber());
    }
    myChart.datasets.push(newDS);
    myBar.update();
  }

  // Add Dataset Horizontal chart

  function addDataHorizontal(){
    var colorName = getRandomColor();
    var newDS = {
      label: 'Salary - ' + (myChart.datasets.length + 1) ,
      backgroundColor: colorName,
      borderColor: colorName,
      fill: false,
      data: []
    }

    for (var i = 0; i < myChart.labels.length; i++){
      newDS.data.push(getRandomNumber());
    }
    myChart.datasets.push(newDS);
    myhorChart.update();
  }

  // Add Dataset Line Chart Multi-Axis
  function addDataMultiAxis(){
    var colorName = getRandomColor();
    var newDS = {
      label: 'Salary - ' + (myChart.datasets.length + 1) ,
      backgroundColor: colorName,
      borderColor: colorName,
      fill: false,
      data: []
    }

    for (var i = 0; i < myChart.labels.length; i++){
      newDS.data.push(getRandomNumber());
    }
    myChart.datasets.push(newDS);
    myLine.update();
  }

  // Random Dataset Pie Chart
  function randomDataPie(){
    // dataPieChart.datasets.forEach(function(dataset){
    //   dataset.data = dataset.data.map(function(){
    //     return getRandomNumber();
    //   });
    // });
    for(var i = 0; i < dataPieChart.labels.length; i++){
      dataPieChart.datasets[0].data[i] = getRandomNumber();
    }
    myPie.update();
  }
