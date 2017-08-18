using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternOfPatterns
{
    class QuackCounter : IQuackable
    {
        private readonly IQuackable _duck;
        private static int _nubmerOfQuacks;
        private readonly Observable _observable;
        public QuackCounter(IQuackable duck)
        {
            _duck = duck;
            _observable = new Observable(this);
        }

        public void Quack()
        {
            _duck.Quack();
            _nubmerOfQuacks++;
        }

        public static int GetQuackCount()
        {
            return _nubmerOfQuacks;
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
