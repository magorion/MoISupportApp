using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using Newtonsoft.Json;
using System.Threading;

namespace MOISupport.GeocodingApi
{
    public class GeolocationService
    {
        //private static readonly string APIKey = "AIzaSyBf7baFDRT3ONioqHMysyllCbWFqeZ2_rg";

        public static Result GetResult(string addr, string type)
        {
            string url = string.Format("http://maps.googleapis.com/maps/api/geocode/json?{0}={1}", type, addr + "&sensor=false");

            var request = WebRequest.Create(url);
            Thread.Sleep(200);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK) return null;

                var ms = new MemoryStream();
                var responseStream = response.GetResponseStream();

                var buffer = new Byte[2048];
                if (responseStream != null)
                {
                    int count = responseStream.Read(buffer, 0, buffer.Length);

                    while (count > 0)
                    {
                        ms.Write(buffer, 0, count);
                        count = responseStream.Read(buffer, 0, buffer.Length);
                    }
                }
                else throw new Exception("Response stream does not exist");

                responseStream.Close();
                ms.Close();

                var responseBytes = ms.ToArray();
                var encoding = new ASCIIEncoding();

                var coords = encoding.GetString(responseBytes);
                RootObject result = JsonConvert.DeserializeObject<RootObject>(coords);

                if(result.status != "ZERO_RESULTS")
                    return result.results[0];
                return null;
            }

            //return null;
        }
    }
}
