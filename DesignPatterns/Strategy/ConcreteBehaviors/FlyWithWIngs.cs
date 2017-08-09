using System;
using Strategy.Behaviors;

namespace Strategy.ConcreteBehaviors
{
    public class FlyWithWIngs : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}
