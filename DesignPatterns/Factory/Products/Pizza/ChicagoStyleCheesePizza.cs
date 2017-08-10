using System;
using Factory.Factories;

namespace Factory.Products.Pizza
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        private IPizzaIngredientsFactory _ingredientsFactory;
        public ChicagoStyleCheesePizza(IPizzaIngredientsFactory ingredientsFactory)
        {
            _ingredientsFactory = ingredientsFactory;
        }

        public override void Prepare()
        {
            throw new NotImplementedException();
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
