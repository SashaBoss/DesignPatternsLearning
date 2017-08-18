﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternOfPatterns
{
    class GooseAdapter : IQuackable
    {
        private readonly Goose _goose;
        private readonly Observable _observable;

        public GooseAdapter(Goose goose)
        {
            _goose = goose;
            _observable = new Observable(this);
        }

        public void Quack()
        {
            _goose.Honk();
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
