using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;

namespace BeaconConnectionExample
{
    public class Log
    {
        private Log()
        {
        }

        private static Log _instance;

        static public Log getInstance()
        {
            if (_instance == null)
            {
                _instance = new Log();
            }
            return _instance;
        }

        public event Events.SenderHandlerString LogReceived = delegate { };

        public void info(string message, bool printNewline = true)
        {
            string line = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff") + " " + message + ((printNewline) ? System.Environment.NewLine : "");
            Console.Write(line);
            try
            {
                File.AppendAllText(Path.Combine(Path.GetTempPath(), "eishockeydisplay.log"), line);
            }
            catch (Exception e)
            {
                Console.WriteLine("could not log into file: " + e.Message);
            }

            //if (LogReceived != null) LogReceived(this, new EventArgsString(line));
        }
    }
}