using System;
using Strategy.Behaviors;

namespace Strategy.ConcreteBehaviors
{
    class Quacker : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
