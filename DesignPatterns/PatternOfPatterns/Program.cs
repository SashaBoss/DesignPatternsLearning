using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternOfPatterns.Factories;
using PatternOfPatterns.Observables;

namespace PatternOfPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            DuckSimulator duckSimulator = new DuckSimulator(new CountingDuckFactory());
            duckSimulator.Simulate();

            Console.ReadLine();
        }
    }

    internal class DuckSimulator
    {
        private readonly AbsractDuckFactory _duckFactory;
        private readonly AbstractGooseFactory _gooseFactory;

        public DuckSimulator(AbsractDuckFactory duckFactory)
        {
            _duckFactory = duckFactory;
            _gooseFactory = new GooseFactory();
        }

        public void Simulate()
        {
            IQuackable mallardDuck = _duckFactory.CreateMallardDuck();
            IQuackable redheadDuck = _duckFactory.CreateRedheadDuck();
            IQuackable duckCall = _duckFactory.CreateDuckCall();
            IQuackable rubberDuck = _duckFactory.CreateRubberDuck();
            IQuackable gooseDuck = _gooseFactory.CreateHonk();

            Flock flockOfDucks = new Flock();
            flockOfDucks.Add(mallardDuck);
            flockOfDucks.Add(duckCall);
            flockOfDucks.Add(rubberDuck);
            flockOfDucks.Add(gooseDuck);
            flockOfDucks.Add(redheadDuck);

            Flock flockOfMallards = new Flock();
            IQuackable mallardOne = _duckFactory.CreateMallardDuck();
            IQuackable mallardTwo = _duckFactory.CreateMallardDuck();
            IQuackable mallardThree = _duckFactory.CreateMallardDuck();
            IQuackable mallardFour = _duckFactory.CreateMallardDuck();

            flockOfMallards.Add(mallardOne);
            flockOfMallards.Add(mallardTwo);
            flockOfMallards.Add(mallardThree);
            flockOfMallards.Add(mallardFour);

            flockOfDucks.Add(flockOfMallards);

            Console.WriteLine("Duck Simulator");
            Quackologist quackologist = new Quackologist();
            flockOfDucks.RegisterObserver(quackologist);

            Trigger(flockOfDucks);

            Console.WriteLine($"The ducks quacked {QuackCounter.GetQuackCount()} times");
        }

        private void Trigger(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
