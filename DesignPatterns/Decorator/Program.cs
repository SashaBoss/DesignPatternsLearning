using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            Console.WriteLine(espresso.GetDescription() + "\t" + espresso.Cost());

            espresso = new Mocha(espresso);
            espresso = new Soy(espresso);

            Console.WriteLine(espresso.GetDescription() + "\t" + espresso.Cost());

            Console.ReadLine();
        }
    }
}
