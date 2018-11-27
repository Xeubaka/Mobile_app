using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace App_standard.Model
{
    public class HttpRequest
    {
        public static HttpClient Client = new HttpClient();

        public static async Task<List<T>> FetchData<T>(string url)
        {
            var uri = new Uri(string.Format(url, string.Empty));
            var response = await Client.GetAsync(uri);

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<T>>(content);
        }
    }
}
