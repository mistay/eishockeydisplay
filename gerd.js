
$( document ).ready(function() {
	console.log("los gehts, yipieeh!");
	
	var oldid=0;
	(function poll() {
	   setTimeout(function() {
			//PRODUCTION//$.ajax({ url: "http://localhost:8080/static/", success: function(data) {
			
			//TESTING//
			$.ajax({ url: ("http://localhost:8080/static/" + oldid), success: function(data) {
				
				console.log(data);
				
				$(".id").html(data.id);
				oldid = data.id;
				$(".clock").html(data.mainClock);
				$(".scoreHome").html(data.scoreHome);
				$(".scoreAway").html(data.scoreAway);
				$(".period").html(data.period);
				$(".clockIsRunning").html(data.clockIsRunning);
				$(".clockIsLastMinute").html(data.clockIsLastMinute);
				$(".TeamnameHome").html(data.TeamnameHome);
				$(".TeamnameAway").html(data.TeamnameAway);
				$(".JerseyNr1").html(data.JerseyNr1);
				$(".JerseyNr2").html(data.JerseyNr2);
				
				
					
				
		   }, dataType: "json", complete: poll });
		}, 500);
	})();
});
