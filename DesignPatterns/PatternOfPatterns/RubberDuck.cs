using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternOfPatterns
{
    class RubberDuck : IQuackable
    {
        private readonly Observable _observable;

        public RubberDuck()
        {
            _observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Squeek");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver o)
        {
            _observable.RegisterObserver(o);
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }
    }
}
