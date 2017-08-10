using Factory.Products;

namespace Factory.Factories
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new ChicagoStyleCheesePizza();
                default:
                    {
                        return null;
                    }
            }
        }
    }
}
