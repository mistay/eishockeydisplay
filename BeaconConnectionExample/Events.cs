using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeaconConnectionExample
{
    public class Events
    {
        public delegate void SenderHandler(object sender, EventArgs e);
        public delegate void SenderHandlerString(object sender, EventArgsString e);
    }
}
