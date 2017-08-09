using System;
using Strategy.Behaviors;

namespace Strategy
{
    public abstract class Duck
    {
        protected IFlyBehavior FlyBehavior;
        protected IQuackBehavior QuackBehavior ;

        protected Duck()
        {
        }

        public abstract void Display();

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks swim");
        }

        public void SetFlyBehavior(IFlyBehavior behavior)
        {
            FlyBehavior = behavior;
        }

        public void SetQuackBehavior(IQuackBehavior behavior)
        {
            QuackBehavior = behavior;
        }
    }
}
