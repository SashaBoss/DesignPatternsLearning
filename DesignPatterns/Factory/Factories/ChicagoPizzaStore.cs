using Factory.Products;
using Factory.Products.Pizza;

namespace Factory.Factories
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    //return new ChicagoStyleCheesePizza(type);
                default:
                    {
                        return null;
                    }
            }
        }
    }
}
