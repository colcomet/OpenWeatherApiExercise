using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace OpenWeatherApiExercise
{
    public class WeatherService
    {
        private IWeatherApiService _service;
        public WeatherService(IWeatherApiService service)
        {
            _service = service;
        }

        public Location GetLocation(string city, string state, string country)
        {
            var locationText = _service.GetLocationDataString(city, state, country);
            var locations = JArray.Parse(locationText);
            if (locations == null || locations.Count == 0)
            {
                return null;
            }
            //Just take the first location.
            var loc = locations[0];
            return new Location()
            {
                City = loc.Value<string>("name"),
                State = loc.Value<string>("state"),
                Country = loc.Value<string>("country"),
                Lat = loc.Value<string>("lat"),
                Lon = loc.Value<string>("lon")
            };
        }
        public WeatherData GetWeatherData(Location location)
        {
            if (location == null) return null;
            var weatherDataString = _service.GetWeatherDataString(location.Lat, location.Lon);
            var weatherOb = JObject.Parse(weatherDataString);
            var locT = weatherOb.GetValue("coord");
            var mainT = weatherOb.GetValue("main");
            var windT = weatherOb.GetValue("wind");
            var weatherT = weatherOb.GetValue("weather")[0];
            return new WeatherData()
            {
                Name = weatherOb.GetValue("name").ToString(),
                Description = weatherT.Value<string>("main"),
                Temp = mainT.Value<decimal>("temp"),
                FeelsLike = mainT.Value<decimal>("feels_like"),
                Humidity = mainT.Value<decimal>("humidity"),
                WindSpeed = windT.Value<decimal>("speed"),
                WindDirection = windT.Value<decimal>("deg")
            };
        }
    }
}
