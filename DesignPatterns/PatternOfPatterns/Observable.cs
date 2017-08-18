using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternOfPatterns
{
    class Observable : IQuackObservable
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private readonly IQuackObservable _duck;

        public Observable(IQuackObservable duck)
        {
            _duck = duck;
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void NotifyObservers()
        {
            _observers.ForEach(o => o.Update(_duck));
        }
    }
}
