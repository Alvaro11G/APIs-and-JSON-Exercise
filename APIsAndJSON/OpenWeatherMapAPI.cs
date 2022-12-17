using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        public static void Weather()
        {
            var client = new HttpClient();

            Console.WriteLine("Enter API key");
            var apiKey = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Enter city name");
            var cityName = Console.ReadLine();

            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=imperial";
            var response = client.GetStringAsync(weatherURL).Result;

            var formattedResponse = JObject.Parse(response).GetValue("main").ToString();

            Console.WriteLine(formattedResponse);
        }
    }
}
