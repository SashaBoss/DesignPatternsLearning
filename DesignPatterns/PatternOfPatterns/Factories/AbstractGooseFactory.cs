using PatternOfPatterns.Observables;

namespace PatternOfPatterns.Factories
{
    abstract class AbstractGooseFactory
    {
        public abstract IQuackable CreateHonk();
    }
}
