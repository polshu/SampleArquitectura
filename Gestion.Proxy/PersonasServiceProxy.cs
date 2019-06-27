using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Helpers;
using Gestion.Entities;

namespace Gestion.Proxy {
    public class PersonasServiceProxy {

        public static string GetAPIDomain() {
            string strReturnValue;
            strReturnValue = AppSettingsHelper.GetAppSetting("HTTPDomainAPI", "");
            return strReturnValue;
        }

        private const string URL = "https://sub.domain.com/objects.json";

        public static List<Persona> GetAll() {
            List<Persona> returnList = new List<Persona>();
            string strURL;
            HttpClient client = new HttpClient();

            strURL = GetAPIDomain();
            client.BaseAddress = new Uri(strURL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync("/api/v1/personas").Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            if (response.IsSuccessStatusCode) {
                // Parse the response body.
                returnList = response.Content.ReadAsAsync<List<Persona>>().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll
            } else {
                //Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            //Make any other calls using HttpClient here.

            //Dispose once all HttpClient calls are complete. This is not necessary if the containing object will be disposed of; for example in this case the HttpClient instance will be disposed automatically when the application terminates so the following call is superfluous.
            client.Dispose();

            return returnList;
        }
    }
}
