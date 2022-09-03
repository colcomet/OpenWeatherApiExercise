using System.IO;
using System.Net.Http;
using System.Web;
using Microsoft.Extensions.Configuration;

namespace OpenWeatherApiExercise
{
    internal class HttpWeatherApiService:IWeatherApiService
    {
        string apiKey;
        private HttpClient _client = new HttpClient();
        public HttpWeatherApiService()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var section = config.GetSection("APIKeys");
            var wcConfig = section.GetSection("WeatherAPIKey");
            apiKey = wcConfig.Value;
        }
        public string GetLocationDataString(string cityName, string stateCode, string countryCode)
        {
            string coordinatesUrl = $"http://api.openweathermap.org/geo/1.0/direct?q={HttpUtility.UrlEncode(cityName)},{HttpUtility.UrlEncode(stateCode)},{HttpUtility.UrlEncode(countryCode)}&limit=5&appid={apiKey}";
            return _client.GetStringAsync(coordinatesUrl).Result;
        }

        public string GetWeatherDataString(string lat, string lon)
        {
            string weatherUrl = $"https://api.openweathermap.org/data/2.5/weather?lat={HttpUtility.UrlEncode(lat)}&lon={HttpUtility.UrlEncode(lon)}&units=imperial&appid={apiKey}";
            return _client.GetStringAsync(weatherUrl).Result;
        }
    }
}
