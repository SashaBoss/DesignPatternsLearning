using System;

namespace PatternOfPatterns.Observables
{
    class Quackologist : IObserver
    {
        public void Update(IQuackObservable duck)
        {
            Console.WriteLine($"Quackologist {duck} just quacked");
        }
    }
}
