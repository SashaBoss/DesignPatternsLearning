using System;
using Strategy.ConcreteBehaviors;

namespace Strategy
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehavior = new FlyWithWIngs();
            QuackBehavior = new Quacker();
        }

        public override void Display()
        {
            Console.WriteLine("I'm mallard duck!");
        }
    }
}
