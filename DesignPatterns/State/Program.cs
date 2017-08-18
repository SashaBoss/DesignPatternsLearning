using System;

namespace State
{
    class Program
    {
        private const int GumballsCount = 10000;

        static void Main(string[] args)
        {
            GumballMachine machine = new GumballMachine(GumballsCount);

            for (int i = 0; i < GumballsCount; i++)
            {
                machine.InsertQuarter();
                machine.TurnCrank();
            }

            Console.ReadLine();
        }
    }
}
