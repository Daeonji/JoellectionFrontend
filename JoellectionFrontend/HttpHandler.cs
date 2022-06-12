using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JoellectionFrontend
{
    public static class HttpHandler
    {
        static HttpClient client = new HttpClient();

        public static async Task UploadJoe(string name, string description, string imageLink)
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

        public static async Task<List<JoeEntry>> GetJoeEntries()
        {
            var url = "http://localhost:7071/api/GetJoes";
            HttpResponseMessage response = await client.GetAsync(url);

            var data = JsonConvert.DeserializeObject<List<JoeEntry>>(await response.Content.ReadAsStringAsync());
            return data;
        }

        public static async Task<Image> GetImage(string url)
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenRead(url);
            Bitmap bitmap; bitmap = new Bitmap(stream);

            MemoryStream imgStream = new MemoryStream();

            if (bitmap != null)
            {
                bitmap.Save(imgStream, ImageFormat.Png);
            }

            stream.Flush();
            stream.Close();
            client.Dispose();
            var image = Image.FromStream(imgStream);
            return image;
        }

        public static async Task<bool> DeleteJoe(JoeEntry entry)
        {
            var jsonReq = JsonConvert.SerializeObject(entry);
            Debug.WriteLine(jsonReq);

            var data = new StringContent(jsonReq, Encoding.UTF8, "application/json");
            var url = "http://localhost:7071/api/DeleteJoe";
            HttpResponseMessage response = await client.PostAsync(url, data);
            try
            {
                response.EnsureSuccessStatusCode();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
