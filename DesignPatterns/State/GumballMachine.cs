using System;
using State.States;

namespace State
{
    public class GumballMachine
    {
        private readonly IState _soldOutState;
        private readonly IState _noQaurterState;
        private readonly IState _hasQuarterState;
        private readonly IState _soldState;
        private readonly IState _winnerState;
        private IState _state;

        int _count;

        public GumballMachine(int numberGumBalls)
        {
            _soldOutState = new SoldOutState(this);
            _noQaurterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);
            _winnerState = new WinnerState(this);

            _state = _noQaurterState;
            _count = numberGumBalls;
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
        }

        public void Dispense()
        {
            _state.Dispense();
        }

        public void SetState(IState newState)
        {
            _state = newState;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (_count != 0)
            {
                _count--;
            }
        }

        public IState GetNoQuarterState()
        {
            return _noQaurterState;
        }

        public IState GetHasQuarterState()
        {
            return _hasQuarterState;
        }

        public IState GetSoldOutState()
        {
            return _soldOutState;
        }

        public IState GetSoldState()
        {
            return _soldState;
        }

        public int GetCount()
        {
            return _count;
        }

        public IState GetWinnerState()
        {
            return _winnerState;
        }
    }
}
