﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class SoldOutState : IState
    {
        GumballMachine machine;

        public SoldOutState(GumballMachine machine)
        {
            this.machine = machine;
        }

        public void InsertQuarter()
        {
            throw new NotImplementedException();
        }

        public void EjectQuarter()
        {
            throw new NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new NotImplementedException();
        }

        public void Dispense()
        {
            throw new NotImplementedException();
        }
    }
}