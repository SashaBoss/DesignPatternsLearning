using System;
using Observer.Contracts;

namespace Observer
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private double _temperature;
        private double _humidity;
        private double _pressure;
        private ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(double temp, double humidity, double pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            _pressure = pressure;
            Dislpay();
        }

        public void Dislpay()
        {
            Console.WriteLine("Current conditions:\n" +
                              $"Temperature = {_temperature} degrees\t" +
                              $"Humidity={_humidity} %\t" +
                              $"Pressure={_pressure} Pa");
        }
    }
}
