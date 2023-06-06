using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UnoControl
{
    public class RequestClass
    {
        string url = "https://raw.githubusercontent.com/temppase/TestDataProvider/main/data.txt";
        string stringContent = "";
        public RequestClass() { }

        public async Task<string> SendData(int length, int time, int count, int dir, int offset)
        {
            using (var wb = new HttpClient())
            {
                Debug.WriteLine("Inside HttpClient");
                var formContent = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("legth", length.ToString()),
                    new KeyValuePair<string, string>("time", time.ToString()),
                    new KeyValuePair<string, string>("count", count.ToString()),
                    new KeyValuePair<string, string>("offset", offset.ToString()),
                    new KeyValuePair<string, string>("direction", dir.ToString())
                });

                var myHttpClient = new HttpClient();
                Debug.WriteLine("Client initalized");
                var response = await myHttpClient.PostAsync(url, formContent); // Test drive did't work (git hub).
                Debug.WriteLine("Response initalized");
                stringContent = await response.Content.ReadAsStringAsync();
                Debug.WriteLine("Response readed");
            }
            Debug.WriteLine(stringContent);
            return stringContent;
        }
    }
}
