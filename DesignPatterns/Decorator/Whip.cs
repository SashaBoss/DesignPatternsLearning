namespace Decorator
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            return 0.43 + _beverage.Cost();
        }
    }
}
