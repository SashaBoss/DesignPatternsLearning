using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Products.Pizza;

namespace Factory.Factories
{
    class CaliforniaPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza p = null;
            switch (type)
            {
                case "cheese":
                    p = new CaliforniaStyleCheesePizza();
                    break;
            }

            return p;
        }
    }
}
