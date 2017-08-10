using System;
using System.Collections.Generic;

namespace Factory.Products
{
    public abstract class Pizza
    {
        protected string Name;
        protected string Dough;
        protected string Sauce;
        protected List<string> Toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine("Tossing dought...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings...");
            Toppings.ForEach(Console.WriteLine);
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Boxing pizza in official pizza store box");
        }

        public string GetName()
        {
            return Name;
        }
    }
}
