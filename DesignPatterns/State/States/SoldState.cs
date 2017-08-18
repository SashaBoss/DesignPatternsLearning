using System;

namespace State.States
{
    public class SoldState : IState
    {
        private readonly GumballMachine _machine;

        public SoldState(GumballMachine machine)
        {
            this._machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry you already turned the cran;");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice, doesn't get you another gumball");
        }

        public void Dispense()
        {
           _machine.ReleaseBall();
            if (_machine.GetCount() > 0)
            {
                _machine.SetState(_machine.GetNoQuarterState());
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs");
                _machine.SetState(_machine.GetSoldOutState());
            }
        }
    }
}
