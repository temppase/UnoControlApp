using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace UnoControl
{
    public class RequestClass
    {

        private string url = "192.168.1.177";
        private string stringContent = "";
        private Int32 port = 23;
        private string message = "";
        public RequestClass() { }


        HttpClient client = new HttpClient();

        public string SendTest(int length, int time, int count, int dir, int offset)
        {

            var formContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("legth", length.ToString()),
                    new KeyValuePair<string, string>("time", time.ToString()),
                    new KeyValuePair<string, string>("count", count.ToString()),
                    new KeyValuePair<string, string>("offset", offset.ToString()),
                    new KeyValuePair<string, string>("direction", dir.ToString())
            });
            using (HttpResponseMessage response = client.PostAsync(url, formContent).GetAwaiter().GetResult())
            {
                using (HttpContent content = response.Content)
                {
                    stringContent = content.ReadAsStringAsync().GetAwaiter().GetResult();
                }
            }

            return stringContent;

        }
        public string TcpSend(string mes)
        {
            try
            {
                // Create a TcpClient.
                // Note, for this client to work you need to have a TcpServer
                // connected to the same address as specified by the server, port
                // combination.
                // Prefer a using declaration to ensure the instance is Disposed later.
                using TcpClient client = new TcpClient(url, port);

                // Translate the passed message into ASCII and store it as a Byte array.
                Byte[] data = Encoding.ASCII.GetBytes(mes);

                // Get a client stream for reading and writing.
                NetworkStream stream = client.GetStream();

                // Send the message to the connected TcpServer.
                stream.Write(data, 0, data.Length);

                message = $"Sent: {mes}\n";

                // Receive the server response.

                // Buffer to store the response bytes.
                data = new Byte[256];

                // String to store the response ASCII representation.
                String responseData = String.Empty;

                // Read the first batch of the TcpServer response bytes.
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = Encoding.ASCII.GetString(data, 0, bytes);
                message += $"Received: {responseData}\n";

                // Explicit close is not necessary since TcpClient.Dispose() will be
                // called automatically.
                // stream.Close();
                // client.Close();
            }
            catch (ArgumentNullException e)
            {
                message += $"ArgumentNullException: {e} \n";
            }
            catch (SocketException e)
            {
                message += $"SocketException: {e}\n";
            }

            message += "EOM\n";
            return message;
        }
    }
}
