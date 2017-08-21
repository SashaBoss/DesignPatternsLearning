namespace PatternOfPatterns.Observables
{
    interface IObserver
    {
        void Update(IQuackObservable duck);
    }
}
