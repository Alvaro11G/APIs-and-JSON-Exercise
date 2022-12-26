using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {

            //for(int i = 1; i <= 5; i++)
            //{
            //    RonVSKanyeAPI.KanyeQuote();

            //    RonVSKanyeAPI.RonQuote();
            //}

            OpenWeatherMapAPI.Weather();
        }
    }
}
