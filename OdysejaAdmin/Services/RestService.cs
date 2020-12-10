using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OdysejaAdmin.Stores;

namespace OdysejaAdmin.Services
{
    public class RestService
    {
        private const string BASE_URL = "http://localhost:8080";
        private static readonly HttpClient client = new HttpClient();

        private UserStore _userStore;

        public RestService(UserStore userStore)
        {
            _userStore = userStore;
        }

        public async Task<HttpResponseMessage> Post(string url, object value)
        {
            using (var content = new StringContent(JsonConvert.SerializeObject(value), System.Text.Encoding.UTF8,
                "application/json"))
            {
                HttpResponseMessage result = client.PostAsync($"{BASE_URL}{url}", content).Result;
                return result;
            }
        }

        public async Task<string> Get(string url)
        {
            HttpResponseMessage response = await client.GetAsync($"{BASE_URL}{url}");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<HttpResponseMessage> Put(string url, object value)
        {
            using (var content = new StringContent(JsonConvert.SerializeObject(value), System.Text.Encoding.UTF8,
                "application/json"))
            {
                HttpResponseMessage result = client.PutAsync($"{BASE_URL}{url}", content).Result;
                return result;
            }
        }

        public async Task<HttpResponseMessage> Delete(string url, string id)
        {
            HttpResponseMessage result = await client.DeleteAsync($"{BASE_URL}{url}/{id}");
            return result;
        }
    }
}