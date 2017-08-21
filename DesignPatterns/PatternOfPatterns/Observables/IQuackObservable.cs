namespace PatternOfPatterns.Observables
{
    interface IQuackObservable
    {
        void RegisterObserver(IObserver o);
        void NotifyObservers();
    }
}
