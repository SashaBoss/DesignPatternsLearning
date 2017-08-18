using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternOfPatterns
{
    class Flock : IQuackable
    {
        private readonly List<IQuackable> _quackers = new List<IQuackable>();

        public void Add(IQuackable quacker)
        {
            _quackers.Add(quacker);
        }

        public void Quack()
        {
            _quackers.ForEach(q => q.Quack());
        }

        public void RegisterObserver(IObserver o)
        {
           _quackers.ForEach(q => q.RegisterObserver(o));
        }

        public void NotifyObservers()
        {
           _quackers.ForEach(q => q.NotifyObservers());
        }
    }
}
