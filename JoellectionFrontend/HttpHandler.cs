using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JoellectionFrontend
{
    public static class HttpHandler
    {
        static HttpClient client = new HttpClient();

        public static async void UploadJoe(string name, string description, string imageLink)
        {

            var req = new JoeRequest();
            req.Name = name;
            req.Description = description;
            req.ImageLink = imageLink;

            var jsonReq = JsonConvert.SerializeObject(req);
            Debug.WriteLine(jsonReq);

            var data = new StringContent(jsonReq, Encoding.UTF8, "application/json");
            var url = "http://localhost:7071/api/FindJoe";
            HttpResponseMessage response = await client.PostAsync(url, data);
            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch
            {

            }
            
        }
    }
}
