using System;

namespace AdapterFacade.DuckAdapter
{
    class DuckTestService
    {
        public void Run()
        {
            IDuck mallardDuck = new MallardDuck();
            ITurkey wildTurkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(wildTurkey);
            ITurkey duckAdapter = new DuckAdapter(mallardDuck);

            Console.WriteLine("The turkey says:");
            wildTurkey.Gobble();
            wildTurkey.Fly();

            Console.WriteLine("The ducs says:");
            TestDuck(mallardDuck);

            Console.WriteLine("The turkey adapter says:");
            TestDuck(turkeyAdapter);

            Console.WriteLine("The duck adapter says:");
            TestTurkey(duckAdapter);
        }

        private void TestDuck(IDuck duck)
        {
            duck.Fly();
            duck.Quack();
        }

        private void TestTurkey(ITurkey turkey)
        {
            turkey.Fly();
            turkey.Gobble();
        }
    }
}
