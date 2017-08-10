using System;
using System.Collections.Generic;
using Factory.Products.Ingredients;

namespace Factory.Products.Pizza
{
    public abstract class Pizza
    {
        protected string Name;
        protected Dough Dough;
        protected Sauce Sauce;
        protected Veggies Veggies;
        protected Cheese Cheese;
        protected Pepperoni Pepperoni;
        protected Clams Clam;

        public abstract void Prepare();

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
