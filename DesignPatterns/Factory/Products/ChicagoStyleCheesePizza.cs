using System;

namespace Factory.Products
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago style deep dish cheese pizza";
            Dough = "Extra thick crust dough";
            Sauce = "Plum tomato sauce";
            Toppings.Add("Shredded mozarella cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
