
$( document ).ready(function() {
	console.log("los gehts, yipieeh!");
	(function poll() {
	   setTimeout(function() {
			//PRODUCTION//$.ajax({ url: "http://localhost:8080/static/", success: function(data) {
			
			//TESTING//
			$.ajax({ url: "http://langhofer.net/eishockeydemo.php", success: function(data) {
				
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
