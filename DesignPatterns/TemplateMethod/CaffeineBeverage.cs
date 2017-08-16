using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        protected virtual bool CustomerWantsCondiments()
        {
            return true;
        }

        protected abstract void AddCondiments();

        protected abstract void Brew();

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}
