using Newtonsoft.Json;

namespace BoletoBus.Web.http
{
    public class ApiHelper
    {
        private readonly HttpClientHandler _httpClientHandler;

        public ApiHelper(HttpClientHandler httpClientHandler)
        {
            _httpClientHandler = httpClientHandler;
        }

        public async Task<T> GetApiResponseAsync<T>(string url) where T : class, new()
        {
            using (var httpClient = new HttpClient(_httpClientHandler))
            {
                using (var response = await httpClient.GetAsync(url))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<T>(apiResponse);
                    }
                }
            }
            return new T();
        }
    }
}
