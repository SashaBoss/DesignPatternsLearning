using System;

namespace AdapterFacade.DuckAdapter
{
    public class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
