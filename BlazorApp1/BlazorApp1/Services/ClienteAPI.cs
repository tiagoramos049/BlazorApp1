using BlazorApp1.Models;
using System.Net.Http;
using System.Runtime.CompilerServices;

namespace BlazorApp1.Services
{
    public class ClienteAPI
    {
        private readonly HttpClient _httpClient;
        public ClienteAPI(IHttpClientFactory factory)
        {
            _httpClient = factory.CreateClient("API");
        }
        public async Task<ICollection<ClienteResponse>?> GetWeatherForecast() 
        {
            return await
                _httpClient.GetFromJsonAsync<ICollection<ClienteResponse>>("WeatherForecast");
        }
    }
}
