using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Coffee : CaffeineBeverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding milk and sugar");
        }

        protected override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }
    }
}
