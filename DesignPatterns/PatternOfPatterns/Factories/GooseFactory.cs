using PatternOfPatterns.Ducks;
using PatternOfPatterns.Observables;

namespace PatternOfPatterns.Factories
{
    class GooseFactory : AbstractGooseFactory
    {
        public override IQuackable CreateHonk()
        {
            return new GooseAdapter(new Goose());
        }
    }
}
