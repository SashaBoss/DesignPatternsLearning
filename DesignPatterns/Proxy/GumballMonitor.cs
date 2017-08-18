using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using State;

namespace Proxy
{
    public class GumballMonitor
    {
        private readonly GumballMachine _machine;

        public GumballMonitor(GumballMachine machine)
        {
            _machine = machine;
        }

        public void Report()
        {
            Console.WriteLine(_machine.GetLocation());
            Console.WriteLine(_machine.GetCount());
            Console.WriteLine(_machine.GetState().ToString());
        }
    }
}
