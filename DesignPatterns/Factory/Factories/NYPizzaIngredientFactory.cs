using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Products.Ingredients;

namespace Factory.Factories
{
    public class NYPizzaIngredientFactory : IPizzaIngredientsFactory
    {
        public Dough CreateDough()
        {
            throw new NotImplementedException();
        }

        public Sauce CreateSauce()
        {
            throw new NotImplementedException();
        }

        public Cheese CreateCheese()
        {
            throw new NotImplementedException();
        }

        public Veggies[] CreateVeggies()
        {
            throw new NotImplementedException();
        }

        public Pepperoni CreatePepperoni()
        {
            throw new NotImplementedException();
        }

        public Clams CreateClams()
        {
            throw new NotImplementedException();
        }
    }
}
