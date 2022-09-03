using System;

namespace OpenWeatherApiExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //used a mock service before API Key was activated
            //WeatherService service = new WeatherService(new MockWeatherApiService());
            WeatherService service = new WeatherService(new HttpWeatherApiService());
            while (true)
            {
                Console.Write("Enter City [Blank to Exit]: ");
                string city = Console.ReadLine();
                if (string.IsNullOrEmpty(city))
                {
                    return;
                }
                Console.Write("Enter State: ");
                string state = Console.ReadLine();
                Console.Write("Enter Country [US]: ");
                string country = Console.ReadLine();
                if (string.IsNullOrEmpty(country)) country = "US";

                var loc = service.GetLocation(city, state, country);
                if (loc == null)
                {
                    Console.WriteLine("That does not appear to be a valid location. Please try again.");
                    continue;
                }
                Console.WriteLine($"Getting weather for {loc.City}, {loc.State}, {loc.Country} - ({loc.Lat}, {loc.Lon})\n");
                var data = service.GetWeatherData(loc);
                if (data == null)
                {
                    Console.WriteLine("Unable to retrieve weather data for location");
                    continue;
                }
                Console.WriteLine($"Currently in {data.Name}, {data.Description}");
                Console.WriteLine($"Temperature: {data.Temp:#0}°F (Feels like {data.FeelsLike:#0}°F)");
                Console.WriteLine($"Humidity:    {data.Humidity:#0}%");
                Console.WriteLine($"Wind:        {data.WindSpeed:#0} mph {GetDirectionText(data.WindSpeed, data.WindDirection)}");
                Console.WriteLine("\n\n");
            }
        }
        public static string GetDirectionText(decimal speed, decimal degrees)
        {
            if (speed <= 0) return "calm";
            string[] dirs = { "N", "NNE", "NE", "ENE", "E", "ESE", "SE", "SSE", "S", "SSW", "SW", "WSW", "W", "WNW", "NW", "NNW", "N" };
            return dirs[(int)Math.Round((degrees * 10 % 3600) / 225)];
        }
    }
}
