using Factory.Products;
using Factory.Products.Pizza;

namespace Factory.Factories
{
    public class NewYorkPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new NewYorkStyleCheesePizza();
                default:
                    {
                        return null;
                    }
            }
        }
    }
}
