using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClientApi
{
    public class HttpHelper
    {
        public static async Task<T> GetJsonAsync<T>(string url) 
        {
            T result = default(T);

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<T>(jsonString);
                }

                return result;
            }
        }

        public static async Task<string> PostJsonAsync<T>(string url, T data)
        {
            using (var client = new HttpClient())
            {
                string result = null;

                var jsonData = JsonConvert.SerializeObject(data);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, content);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    result = await response.Content.ReadAsStringAsync();
                }

                return result;
            }
        }

        public static async Task DeleteJsonAsync(string url)
        {
            using (var client = new HttpClient())
            {
                var response = await client.DeleteAsync(url);

                response.EnsureSuccessStatusCode();
            }
        }
    }
}
