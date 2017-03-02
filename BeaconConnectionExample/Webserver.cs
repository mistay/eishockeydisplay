using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.WebSockets;
using System.Security.Permissions;
using System.Diagnostics;

namespace BeaconConnectionExample
{
    abstract class Webserver
    {
        public static void tryAddingACL(string filename, string arguments)
        {
            ProcessStartInfo psi = new ProcessStartInfo(filename, arguments);
            psi.Verb = "runas";
            psi.CreateNoWindow = true;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.UseShellExecute = true;

            Process.Start(psi).WaitForExit();

            return;

        }
        public async void Start(string url)
        {
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add(url);
            try
            {
                listener.Start();
            }
            catch (Exception e)
            {
                Log.getInstance().info("could not start webserver: " + e.Message);
                Log.getInstance().info("try (as root): netsh http add urlacl url=" + url + " user=" + System.Security.Principal.WindowsIdentity.GetCurrent().Name);
                tryAddingACL("netsh", String.Format(@"http add urlacl url={0} user={1}", url, System.Security.Principal.WindowsIdentity.GetCurrent().Name));

            }

            Log.getInstance().info("started http server: " + url);

            if (listener.IsListening)
                while (true)
                {
                    HttpListenerContext listenerContext = await listener.GetContextAsync();
                    ProcessRequest(listenerContext);
                }
        }
        public abstract void ProcessRequest(HttpListenerContext listenerContext);
    }
}