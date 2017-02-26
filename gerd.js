
$( document ).ready(function() {
	console.log("los gehts, yipieeh!");
	(function poll() {
	   setTimeout(function() {
		   $.ajax({ url: "http://localhost:8080/static/", success: function(data) {
				
				console.log(data);
				
				$(".clock").html(data.mainClock);
				$(".scoreHome").html(data.scoreHome);
				$(".scoreAway").html(data.scoreAway);
				$(".period").html(data.period);
				$(".clockIsRunning").html(data.clockIsRunning);
				$(".clockIsLastMinute").html(data.clockIsLastMinute);
				
		   }, dataType: "json", complete: poll });
		}, 500);
	})();
});
