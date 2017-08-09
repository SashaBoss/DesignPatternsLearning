using System;
using Strategy.Behaviors;

namespace Strategy.ConcreteBehaviors
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Silence!");
        }
    }
}
