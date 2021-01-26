$( function() {
    $("#add_output_btn").draggable();
    $("#avg_output_btn").draggable();
    $("#bar_graph_btn").draggable();
    $("#pie_chart_btn").draggable();

    $iteration = 0;
})

/*

function newTable() {
    var text = "Table";

    var $table = $('<div class="widget"><div class="widgetElement" id="widgetSource' + $iteration + '">SOURCE</div><div class="widgetElement" id="widgetFunction' + $iteration + '">FUNCTION</div><div class="widgetElement" id="widgetChart' + $iteration + '">CHART</div><div class="widgetElement" id="widgetOutput' + $iteration + '">OUTPUT</div><button class="widgetButton" id="widgetButton' + $iteration + '">Run</button></div>');

    $table.draggable();

    $table.appendTo('#work-area');
}

function newWidget() {
    var text = "Table";

    var $table = $('<div class="widget"><div class="widgetElement" id="widgetSource' + $iteration + '"><h3>TABLE</h3><table><h2>Final Grades: Intro to Brevity</h2><tr><th>First Name</th><th>Last Name</th><th>Grade</th> </tr><tr><td>Nancy</td><td>Wilson</td><td>A-</td></tr><tr><td>Charles</td><td>Berry</td><td>B-</td></tr><tr><td>James</td><td>Page</td><td>D+</td></tr><tr><td>Peter</td><td>Townshend</td><td>A-</td></tr><tr><td>Eric</td><td>Clapton</td><td>B</td></tr><tr><td>Carol</td><td>Kaye</td><td>A-</td></tr></table></div><div class="widgetElement" id="widgetFunction' + $iteration + '"><h3>FUNCTION</h3></div><div class="widgetElement" id="widgetChart' + $iteration + '"><h3>CHART</h3></div><div class="widgetElement" id="widgetOutput' + $iteration + '"><h3>Output</h3><div class="widgetOutputChart" id="widgetOutputChart' + $iteration + '"></div></div><button class="widgetButton" id="widgetButton' + $iteration + '" onclick="runWidget0(' + $iteration + ')">Run</button></div>');

    $table.appendTo('#work-area');

    $iteration += 1;
}

function runWidget0(x) {
    $elementId = 'widgetOutputChart' + x
    var chart = new CanvasJS.Chart($elementId, {
		title:{
			text: "Final Grades"              
		},
		data: [              
		{
			// Change type to "doughnut", "line", "splineArea", etc.
			type: "column",
			dataPoints: [
				{ label: "A-",  y: 3  },
				{ label: "B", y: 1  },
				{ label: "B-", y: 1  },
				{ label: "D+",  y: 1  },
			]
		}
		]
	});
	chart.render();

    var text = "Average";

    var $Average = $('<h3>Average: B</h3>');

    $Average.appendTo('#widgetOutput' + x);

*/
}