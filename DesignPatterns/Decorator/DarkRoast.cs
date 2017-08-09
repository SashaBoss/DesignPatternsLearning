namespace Decorator
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "DarkRoast";
        }

        public override double Cost()
        {
            return 0.99;
        }
    }
}
