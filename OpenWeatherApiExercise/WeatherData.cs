using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeatherApiExercise
{
    public class WeatherData
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Temp { get; set; }
        public decimal FeelsLike { get; set; }
        public decimal Humidity { get; set; }
        public decimal WindSpeed { get; set; }
        public decimal WindDirection { get; set; }
    }
}
