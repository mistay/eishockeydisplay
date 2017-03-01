using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeaconConnectionExample
{
    public class Data
    {
        private static Data instance = null;
        public static Data getInstance()
        {
            if (instance == null)
                instance = new Data();

            return instance;
        }

        private Data()
        {

        }

        public long id = 0;
        public  String mainClock="";
        public  String scoreHome = "";
        public  String  scoreAway = "";
        public  String period = "";
        public  Boolean clockIsRunning = false;
        public  Boolean clockIsLastMinute = false;
        public String TeamnameHome = "";
        public String TeamnameAway = "";
        public String JerseyNr1 = "";
        public String JerseyNr2 = "";

        public string ShootoutScoreAway = "";
        public string ShootoutScoreHome = "";


        public String penalty1homejersey = "";
        public String penalty1homeClockMinutesCorrected = "";
        public String penalty1homeClockSecondsCorrected = "";

        public String penalty2homejersey = "";
        public String penalty2homeClockMinutesCorrected = "";
        public String penalty2homeClockSecondsCorrected = "";

        public String penalty1awayjersey = "";
        public String penalty1awayClockMinutesCorrected = "";
        public String penalty1awayClockSecondsCorrected = "";

        public String penalty2awayjersey = "";
        public String penalty2awayClockMinutesCorrected = "";
        public String penalty2awayClockSecondsCorrected = "";

    }
}
