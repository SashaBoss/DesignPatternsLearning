using System.Collections.Generic;
using Observer.Contracts;

namespace Observer
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers;
        private double _temperature;
        private double _humidity;
        private double _pressure;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void MeasuremetsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(double temp, double humidity, double pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            _pressure = pressure;
            MeasuremetsChanged();
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }
    }
}
