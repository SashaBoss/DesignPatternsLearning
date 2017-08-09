namespace Decorator
{
    public abstract class Beverage
    {
        protected string Description = "Unknown beverage";

        public string GetDescription()
        {
            return Description;
        }

        public abstract double Cost();
    }
}

