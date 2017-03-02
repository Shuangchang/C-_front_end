using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RestUtil
{
    public class Rest
    {
        private string baseUri;
        public Rest(String uri)
        {
            baseUri = uri;
        }
        #region getRestData - Return the requested API information as a string
        public string getRestData(string v)
        {
          
            var webRequest = (HttpWebRequest)WebRequest.Create(baseUri + v);
            try
            {
                var webResponse = webRequest.GetResponse();
                using (var responseStream = webResponse.GetResponseStream())
                {
                    var streamReader = new StreamReader(responseStream, Encoding.UTF8);
                    return streamReader.ReadToEnd();
                }
            }
            catch (WebException exception)
            {
                //get error message to debug
                var webResponse = exception.Response;
                using (var responseStream = webResponse.GetResponseStream())
                {
                    var streamReader = new StreamReader(responseStream, Encoding.UTF8);
                    var errorText = streamReader.ReadToEnd();
                    //print the error message on console
                    Console.Write(errorText);
                }
                throw;
            }
        }//end getRestData
        #endregion
    }
}
