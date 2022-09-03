using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeatherApiExercise
{
    //Returns mock data for testing parsing; used before API key was activated
    public class MockWeatherApiService : IWeatherApiService
    {
        //parameters not used; simply returning sample data.
        public string GetLocationDataString(string cityName, string stateCode, string countryCode)
        {
            //Data from example response on openweathewrmap.org website
            return $"[\r\n  {{\r\n    \"name\": \"London\",\r\n    \"local_names\": {{\r\n      \"af\": \"Londen\",\r\n      \"ar\": \"لندن\",\r\n      \"ascii\": \"London\",\r\n      \"az\": \"London\",\r\n      \"bg\": \"Лондон\",\r\n      \"ca\": \"Londres\",\r\n      \"da\": \"London\",\r\n      \"de\": \"London\",\r\n      \"el\": \"Λονδίνο\",\r\n      \"en\": \"London\",\r\n      \"eu\": \"Londres\",\r\n      \"fa\": \"لندن\",\r\n      \"feature_name\": \"London\",\r\n      \"fi\": \"Lontoo\",\r\n      \"fr\": \"Londres\",\r\n      \"gl\": \"Londres\",\r\n      \"he\": \"לונדון\",\r\n      \"hi\": \"लंदन\",\r\n      \"hr\": \"London\",\r\n      \"hu\": \"London\",\r\n      \"id\": \"London\",\r\n      \"it\": \"Londra\",\r\n      \"ja\": \"ロンドン\",\r\n      \"la\": \"Londinium\",\r\n      \"lt\": \"Londonas\",\r\n      \"mk\": \"Лондон\",\r\n      \"nl\": \"Londen\",\r\n      \"no\": \"London\",\r\n      \"pl\": \"Londyn\",\r\n      \"pt\": \"Londres\",\r\n      \"ro\": \"Londra\",\r\n      \"ru\": \"Лондон\",\r\n      \"sk\": \"Londýn\",\r\n      \"sl\": \"London\",\r\n      \"sr\": \"Лондон\",\r\n      \"th\": \"ลอนดอน\",\r\n      \"tr\": \"Londra\",\r\n      \"vi\": \"Luân Đôn\",\r\n      \"zu\": \"ILondon\"\r\n    }},\r\n    \"lat\": 51.5085,\r\n    \"lon\": -0.1257,\r\n    \"country\": \"GB\"\r\n  }},\r\n  {{\r\n    \"name\": \"London\",\r\n    \"local_names\": {{\r\n      \"ar\": \"لندن\",\r\n      \"ascii\": \"London\",\r\n      \"bg\": \"Лондон\",\r\n      \"de\": \"London\",\r\n      \"en\": \"London\",\r\n      \"fa\": \"لندن، انتاریو\",\r\n      \"feature_name\": \"London\",\r\n      \"fi\": \"London\",\r\n      \"fr\": \"London\",\r\n      \"he\": \"לונדון\",\r\n      \"ja\": \"ロンドン\",\r\n      \"lt\": \"Londonas\",\r\n      \"nl\": \"London\",\r\n      \"pl\": \"London\",\r\n      \"pt\": \"London\",\r\n      \"ru\": \"Лондон\",\r\n      \"sr\": \"Лондон\"\r\n    }},\r\n    \"lat\": 42.9834,\r\n    \"lon\": -81.233,\r\n    \"country\": \"CA\"\r\n  }},\r\n  {{\r\n    \"name\": \"London\",\r\n    \"local_names\": {{\r\n      \"ar\": \"لندن\",\r\n      \"ascii\": \"London\",\r\n      \"en\": \"London\",\r\n      \"fa\": \"لندن، اوهایو\",\r\n      \"feature_name\": \"London\",\r\n      \"sr\": \"Ландон\"\r\n    }},\r\n    \"lat\": 39.8865,\r\n    \"lon\": -83.4483,\r\n    \"country\": \"US\",\r\n    \"state\": \"OH\"\r\n  }},\r\n  {{\r\n    \"name\": \"London\",\r\n    \"local_names\": {{\r\n      \"ar\": \"لندن\",\r\n      \"ascii\": \"London\",\r\n      \"en\": \"London\",\r\n      \"fa\": \"لندن، کنتاکی\",\r\n      \"feature_name\": \"London\",\r\n      \"sr\": \"Ландон\"\r\n    }},\r\n    \"lat\": 37.129,\r\n    \"lon\": -84.0833,\r\n    \"country\": \"US\",\r\n    \"state\": \"KY\"\r\n  }},\r\n  {{\r\n    \"name\": \"London\",\r\n    \"local_names\": {{\r\n      \"ascii\": \"London\",\r\n      \"ca\": \"Londres\",\r\n      \"en\": \"London\",\r\n      \"feature_name\": \"London\"\r\n    }},\r\n    \"lat\": 36.4761,\r\n    \"lon\": -119.4432,\r\n    \"country\": \"US\",\r\n    \"state\": \"CA\"\r\n  }}\r\n]";
        }

        //parameters not used; simply returning sample data.
        public string GetWeatherDataString(string lat, string lon)
        {
            //Data from example response on openweathewrmap.org website
            return $"{{\r\n  \"coord\": {{\r\n    \"lon\": -122.08,\r\n    \"lat\": 37.39\r\n  }},\r\n  \"weather\": [\r\n    {{\r\n      \"id\": 800,\r\n      \"main\": \"Clear\",\r\n      \"description\": \"clear sky\",\r\n      \"icon\": \"01d\"\r\n    }}\r\n  ],\r\n  \"base\": \"stations\",\r\n  \"main\": {{\r\n    \"temp\": 282.55,\r\n    \"feels_like\": 281.86,\r\n    \"temp_min\": 280.37,\r\n    \"temp_max\": 284.26,\r\n    \"pressure\": 1023,\r\n    \"humidity\": 100\r\n  }},\r\n  \"visibility\": 10000,\r\n  \"wind\": {{\r\n    \"speed\": 1.5,\r\n    \"deg\": 350\r\n  }},\r\n  \"clouds\": {{\r\n    \"all\": 1\r\n  }},\r\n  \"dt\": 1560350645,\r\n  \"sys\": {{\r\n    \"type\": 1,\r\n    \"id\": 5122,\r\n    \"message\": 0.0139,\r\n    \"country\": \"US\",\r\n    \"sunrise\": 1560343627,\r\n    \"sunset\": 1560396563\r\n  }},\r\n  \"timezone\": -25200,\r\n  \"id\": 420006353,\r\n  \"name\": \"Mountain View\",\r\n  \"cod\": 200\r\n  }}";
        }
    }
}
