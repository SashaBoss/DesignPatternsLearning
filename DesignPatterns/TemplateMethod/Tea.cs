using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Tea : CaffeineBeverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Add lemon");
        }

        protected override void Brew()
        {
            Console.WriteLine("Steeping tea bag");
        }

        protected override bool CustomerWantsCondiments()
        {
            return false;
        }
    }
}
