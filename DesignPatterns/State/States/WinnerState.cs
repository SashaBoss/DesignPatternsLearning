using System;

namespace State.States
{
    public class WinnerState : IState
    {
        private readonly GumballMachine _machine;

        public WinnerState(GumballMachine machine)
        {
            _machine = machine;
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
            Console.WriteLine("You are a winner, shut up and take two balls");
            _machine.ReleaseBall();
            if (_machine.GetCount() == 0)
            {
                _machine.SetState(_machine.GetSoldOutState());
            }
            else
            {
                _machine.ReleaseBall();
                if (_machine.GetCount() > 0)
                {
                    _machine.SetState(_machine.GetNoQuarterState());
                }
                else
                {
                    Console.WriteLine("Oops out of gumballs");
                    _machine.SetState(_machine.GetSoldOutState());
                }
            }
        }
    }
}
