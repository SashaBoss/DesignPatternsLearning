using System;

namespace State.States
{
    public class HasQuarterState : IState
    {
        private readonly Random _randomWinner;
        private readonly GumballMachine _machine;

        public HasQuarterState(GumballMachine machine)
        {
            this._machine = machine;
            _randomWinner = new Random();
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _machine.SetState(_machine.GetNoQuarterState());
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned");
            int winner = _randomWinner.Next(10);
            if (winner == 0 && _machine.GetCount() > 1)
            {
                _machine.SetState(_machine.GetWinnerState());
            }
            else
            {
                _machine.SetState(_machine.GetSoldState());
            }
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }
}
