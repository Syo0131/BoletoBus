using BoletoBus.Web.Models;
using Newtonsoft.Json;
using System.Text;

namespace BoletoBus.Web.Services
{
    public class ApiServices
    {
        private readonly HttpClient _httpClient;

        public ApiServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<BaseResult<T>> Get<T>(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<BaseResult<T>>(jsonResponse);
            }
            else
            {
                return new BaseResult<T>
                {
                    success = false,
                    message = $"Error al obtener datos de la API: {response.ReasonPhrase}"
                };
            }
        }


        public async Task<BaseResult<T>> Post<T>(string url, T data)
        {
            var jsonContent = JsonConvert.SerializeObject(data);
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync(url, contentString);
            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<BaseResult<T>>(jsonResponse);
            }
            else
            {
                return new BaseResult<T>
                {
                    success = false,
                    message = $"Error al enviar datos a la API: {response.ReasonPhrase}"
                };
            }
        }


        public async Task<BaseResult<T>> DeleteAsync<T>(string url)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<BaseResult<T>>(jsonResponse);
            }
            else
            {
                return new BaseResult<T>
                {
                    success = false,
                    message = $"Error al eliminar datos de la API: {response.ReasonPhrase}"
                };
            }
        }
    }
}
