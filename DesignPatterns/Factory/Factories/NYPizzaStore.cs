using Factory.Products;
using Factory.Products.Pizza;

namespace Factory.Factories
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new NYStyleCheesePizza();
                default:
                    {
                        return null;
                    }
            }
        }
    }
}
