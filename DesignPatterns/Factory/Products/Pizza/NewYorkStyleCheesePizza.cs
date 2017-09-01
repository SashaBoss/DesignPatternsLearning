using System;

namespace Factory.Products.Pizza
{
    public class NewYorkStyleCheesePizza : Pizza
    {
        public NewYorkStyleCheesePizza()
        {
        }

        public override void Prepare()
        {
            Console.WriteLine("Zharim na kostre 3 chasa");
        }
    }
}
