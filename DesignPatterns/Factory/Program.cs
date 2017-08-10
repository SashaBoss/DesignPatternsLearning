using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Factories;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var nyStore = new NYPizzaStore();
            var chicagoStore = new ChicagoPizzaStore();

            var nyCheesePizza = nyStore.OrderPizza("cheese");
            var chicagoCheesePizza = chicagoStore.OrderPizza("cheese");

            Console.WriteLine(nyCheesePizza.GetName());
            Console.WriteLine(chicagoCheesePizza.GetName());

            Console.ReadLine();
        }
    }
}
