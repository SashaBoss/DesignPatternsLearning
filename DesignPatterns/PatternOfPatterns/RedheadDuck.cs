using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternOfPatterns
{
    class RedheadDuck : IQuackable
    {
        private readonly Observable _observable;

        public RedheadDuck()
        {
            _observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
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
