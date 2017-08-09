using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            var currentConditions = new CurrentConditionsDisplay(weatherData);
            var heatIndex = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurements(25, 14, 1000);
            weatherData.SetMeasurements(33, 114, 10200);
            weatherData.SetMeasurements(33, 33, 10);

            Console.ReadLine();
        }
    }
}
