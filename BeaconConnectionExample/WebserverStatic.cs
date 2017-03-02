using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Web;
using System.Threading;

namespace BeaconConnectionExample
{
    class WebserverStatic : Webserver
    {
        private static byte[] ReadFully(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }

        public override void ProcessRequest(HttpListenerContext context)
        {
            //Log.getInstance().info("client connected");
            HttpListenerRequest request = context.Request;
            HttpListenerResponse response = context.Response;

            string find = "/static/";



            Log.getInstance().info(context.Request.RawUrl);


            long oldid = 0;

            try
            {
                oldid = long.Parse(context.Request.RawUrl.Remove(context.Request.RawUrl.IndexOf(find), find.Length));
            }
            catch (Exception e)
            {
                // do not log, log runs out of space. id not neccessarily needed
                // Log.getInstance().info("could not parse id from http request: " + e.ToString());
            }


            //while (oldid != Data.getInstance().id)
            {
                // data did not change, wait ...
                //Log.getInstance().info("waiting...");
                //Thread.Sleep(3000);
                //break;
            }

            byte[] buffer = null;
            response.StatusCode = 200;

            response.AddHeader("Access-Control-Allow-Origin", "*");


            var jsonSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();

            string json = jsonSerializer.Serialize(Data.getInstance());


            buffer = System.Text.Encoding.UTF8.GetBytes(json);
            response.ContentLength64 = buffer.Length;

            if (buffer != null)
            {
                System.IO.Stream output = response.OutputStream;
                try
                {
                    output.Write(buffer, 0, buffer.Length);
                }
                catch (Exception e)
                {
                    Log.getInstance().info("could not talk to client: " + e.Message);
                }
                //Log.getInstance().info("wrote to client");
                output.Flush();
                output.Close();
            }
            //Log.getInstance().info("done speaking to client");

            response.Close();
        }
    }
}