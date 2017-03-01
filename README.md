# eishockeydisplay
binary for displaying hockeydata clock in web.

## testing
download both gerd.html and gerd.js and open gerd.html in browser (ff)
make sure gerd.js points to http://langhofer.net/eishockeydemo.php
			
## production
- install time server 3rdparty/UhrensimulationV2.1.zip or http://tournament.hockeydata.net/download/inmotiotec/UhrensimulationV2.1.zip
- (demo) compile c# demo 3rdparty/BeaconConnectionExample-V3.zip or http://tournament.hockeydata.net/download/inmotiotec/BeaconConnectionExample-V3.zip
- unzip Release.zip to your favourite path, start BeaconConnectionExample.exe
- additionally (if either demo or production exe fails): install c++ redistributeble 2010 32bit from m$ (hint by hockeydata), maybe this one? https://www.microsoft.com/en-us/download/details.aspx?id=5555

## build
don't know why but "publish app" builds app that cannot connect via zeromq to server. just zipping release/ folder works. so, build app in release, anycpu or whatever you like, zip release/ and deploy to display.

## configuration
After clicking on "connect" this application saves both ip address and port into local settings (c#). after application launch these settings are loaded.

## special thanks
to gerd.