using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class GumballMachine
    {
        private IState _soldOutState;
        private IState _noQaurterState;
        private IState _hasQuarterState;
        private IState _soldState;
        private IState _state;

        int _count;

        public GumballMachine(int numberGumBalls)
        {
            _soldOutState = new SoldOutState(this);
            _noQaurterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldOutState = new SoldOutState(this);

            _state = _soldOutState;
            _count = numberGumBalls;
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
            //switch (_state)
            //{
            //    case MachineState.HasQuarter:
            //        Console.WriteLine("You can't insert another quarter");
            //        break;
            //    case MachineState.NoQuarter:
            //        _state = MachineState.HasQuarter;
            //        Console.WriteLine("You inserted a quarter");
            //        break;
            //    case MachineState.SoldOut:
            //        Console.WriteLine("You can't insert a quarter, the machine is sold out");
            //        break;
            //    case MachineState.Sold:
            //        Console.WriteLine("Please wait, we're already giving you a gumball");
            //        break;
            //}
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
            //switch (_state)
            //{
            //    case MachineState.HasQuarter:
            //        Console.WriteLine("Quarter returned");
            //        _state = MachineState.NoQuarter;
            //        break;
            //    case MachineState.NoQuarter:
            //        Console.WriteLine("You haven't inserted a quarter");
            //        break;
            //    case MachineState.SoldOut:
            //        Console.WriteLine("You can't eject, you haven't inserted a quarter");
            //        break;
            //    case MachineState.Sold:
            //        Console.WriteLine("Sorry, you have already turned the crank");
            //        break;
            //}
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
            //switch (_state)
            //{
            //    case MachineState.HasQuarter:
            //        Console.WriteLine("You turned");
            //        _state = MachineState.Sold;
            //        break;
            //    case MachineState.NoQuarter:
            //        _state = MachineState.HasQuarter;
            //        Console.WriteLine("You turned but there is no quarter");
            //        break;
            //    case MachineState.SoldOut:
            //        Console.WriteLine("You turned but there are no gumballs");
            //        break;
            //    case MachineState.Sold:
            //        Console.WriteLine("Turning twice doesn't get you another gumball");
            //        break;
            //}
        }

        public void Dispense()
        {
            _state.Dispense();
            //switch (_state)
            //{
            //    case MachineState.HasQuarter:
            //        Console.WriteLine("No gumballs dispensed");
            //        break;
            //    case MachineState.NoQuarter:
            //        _state = MachineState.HasQuarter;
            //        Console.WriteLine("You need to pay first");
            //        break;
            //    case MachineState.SoldOut:
            //        Console.WriteLine("No gumball dispensed");
            //        break;
            //    case MachineState.Sold:
            //        Console.WriteLine("The gumball comes rolling out the slot");
            //        _count--;
            //        _state = _count == 0 ? MachineState.SoldOut : MachineState.NoQuarter;
            //        break;
            //}
        }
    }
}
