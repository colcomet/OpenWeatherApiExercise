using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeatherApiExercise
{
    public interface IWeatherApiService
    {
        public string GetLocationDataString(string cityName, string stateCode, string countryCode);
        public string GetWeatherDataString(string lat, string lon);
    }
}
