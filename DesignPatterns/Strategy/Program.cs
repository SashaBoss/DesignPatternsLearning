using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.ConcreteBehaviors;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var mallardDuck = new MallardDuck();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();

            var modelDuck = new ModelDuck();
            modelDuck.PerformFly();

            modelDuck.SetFlyBehavior(new FlyRocketPowered());
            modelDuck.PerformFly();

            Console.ReadLine();
        }
    }
}
