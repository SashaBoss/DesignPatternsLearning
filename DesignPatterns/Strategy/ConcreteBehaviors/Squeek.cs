using System;
using Strategy.Behaviors;

namespace Strategy.ConcreteBehaviors
{
    public class Squeek : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeek!");
        }
    }
}
