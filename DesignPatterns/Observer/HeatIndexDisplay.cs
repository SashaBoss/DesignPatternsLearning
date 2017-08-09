using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Contracts;

namespace Observer
{
    public class HeatIndexDisplay : IObserver, IDisplayElement
    {
        private double _heatIndex;
        private ISubject _weatherData;

        public HeatIndexDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(double temp, double humidity, double pressure)
        {
            _heatIndex = temp * humidity / pressure;
            Dislpay();
        }

        public void Dislpay()
        {
            Console.WriteLine($"Heat Index ={_heatIndex}");
        }
    }
}
