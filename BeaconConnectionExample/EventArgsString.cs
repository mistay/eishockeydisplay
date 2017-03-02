using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeaconConnectionExample
{
    public class EventArgsString
    {
        private readonly string data;

        public EventArgsString(string data)
        {
            this.data = data;
        }

        public string Data
        {
            get { return this.data; }

        }
    }
}
