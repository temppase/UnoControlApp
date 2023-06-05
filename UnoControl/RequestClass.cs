using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        string url = "";
        string stringContent = "";
        public RequestClass() { }

        public async Task<string> SendData(int length, int time, int count, int dir, int offset, string state)
        {
            using (var wb = new HttpClient())
            {

                var formContent = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("legth", length.ToString()),
                    new KeyValuePair<string, string>("time", time.ToString()),
                    new KeyValuePair<string, string>("count", count.ToString()),
                    new KeyValuePair<string, string>("offset", offset.ToString()),
                    new KeyValuePair<string, string>("direction", dir.ToString()),
                    new KeyValuePair<string, string>("state", state)
                });

                var myHttpClient = new HttpClient();
                var response = await myHttpClient.PostAsync(url, formContent);
                stringContent = await response.Content.ReadAsStringAsync();
            }
            return stringContent;
        }
    }
}
