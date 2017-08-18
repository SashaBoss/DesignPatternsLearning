using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using State;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 112;
            string location = "Denver";

            GumballMachine machine = new GumballMachine(location, count);
            GumballMonitor monitor = new GumballMonitor(machine);

            monitor.Report();

            Console.ReadLine();
        }
    }
}
