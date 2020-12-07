using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Sockets;
using Newtonsoft.Json.Linq;

namespace dbAPI
{
    public class api
    {

        HttpClient client = new HttpClient();

        string _ip;
        string _port;
        public api(string ip, string port)
        {
            _ip = ip;
            _port = port;

            client.BaseAddress = new Uri($"http://{_ip}:{_port}/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        private StringContent jsonConv(object obj)
        {
            var myContent = JsonConvert.SerializeObject(obj);
            Console.WriteLine(myContent);
            var stringContent = new StringContent(myContent, UnicodeEncoding.UTF8, "application/json");
            return stringContent;
        }

        public Task<string> api_getQueue()
        {
            Task<HttpResponseMessage> response = client.GetAsync("dbgetQueue/");
            Task<string> data = response.Result.Content.ReadAsStringAsync();
            Console.WriteLine("From api get dbgetQueue");
            Console.WriteLine(data);
            return data;
        }
    }
}
