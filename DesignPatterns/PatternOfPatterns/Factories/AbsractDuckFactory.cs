using PatternOfPatterns.Observables;

namespace PatternOfPatterns.Factories
{
    abstract class AbsractDuckFactory
    {
        public abstract IQuackable CreateMallardDuck();
        public abstract IQuackable CreateRedheadDuck();
        public abstract IQuackable CreateDuckCall();
        public abstract IQuackable CreateRubberDuck();
    }
}
