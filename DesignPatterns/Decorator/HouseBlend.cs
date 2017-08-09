namespace Decorator
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend coffee";
        }

        public override double Cost()
        {
            return 0.89;
        }
    }
}
