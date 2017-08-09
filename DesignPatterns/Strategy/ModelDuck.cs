using System;
using Strategy.ConcreteBehaviors;

namespace Strategy
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Quacker();
        }
        public override void Display()
        {
            Console.WriteLine("I'm model ducK!");
        }
    }
}
