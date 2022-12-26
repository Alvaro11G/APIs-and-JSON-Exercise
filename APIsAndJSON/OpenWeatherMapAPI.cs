using System;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {

        public static void Weather()
        {
            var client = new HttpClient();

            var config = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            string? authKey = config.GetConnectionString("AuthKey");

            Console.WriteLine("Enter city name");
            var cityName = Console.ReadLine();

            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={authKey}&units=imperial";
            var response = client.GetStringAsync(weatherURL).Result;

            var formattedResponse = JObject.Parse(response).GetValue("main").ToString();

            Console.WriteLine(formattedResponse);
        }
    }
}
