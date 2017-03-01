
$( document ).ready(function() {
	console.log("los gehts, yipieeh!");
	
	var oldid=0;
	(function poll() {
	   setTimeout(function() {
			//PRODUCTION//$.ajax({ url: "http://localhost:8080/static/", success: function(data) {
			
			//TESTING//
			$.ajax({ url: ("http://langhofer.net/eishockeydemo.php/" + oldid), success: function(data) {
				
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
				$(".ShootoutScoreAway").html(data.ShootoutScoreAway);
				$(".ShootoutScoreHome").html(data.ShootoutScoreHome);
				$(".penalty1homejersey").html(data.penalty1homejersey);
				$(".penalty1homeClockMinutesCorrected").html(data.penalty1homeClockMinutesCorrected);
				$(".penalty1homeClockSecondsCorrected").html(data.penalty1homeClockSecondsCorrected);
				$(".penalty2homejersey").html(data.penalty2homejersey);
				$(".penalty2homeClockMinutesCorrected").html(data.penalty2homeClockMinutesCorrected);
				$(".penalty2homeClockSecondsCorrected").html(data.penalty2homeClockSecondsCorrected);
				$(".penalty1awayjersey").html(data.penalty1awayjersey);
				$(".penalty1awayClockMinutesCorrected").html(data.penalty1awayClockMinutesCorrected);
				$(".penalty1awayClockSecondsCorrected").html(data.penalty1awayClockSecondsCorrected);
				$(".penalty2awayjersey").html(data.penalty2awayjersey);
				$(".penalty2awayClockMinutesCorrected").html(data.penalty2awayClockMinutesCorrected);
				$(".penalty2awayClockSecondsCorrected").html(data.penalty2awayClockSecondsCorrected);
				
				
		   }, dataType: "json", complete: poll });
		}, 500);
	})();
});
