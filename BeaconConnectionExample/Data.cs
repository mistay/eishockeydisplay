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

    }
}
