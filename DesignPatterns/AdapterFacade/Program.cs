using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterFacade.DuckAdapter;

namespace AdapterFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            new DuckTestService().Run();

            Console.ReadLine();
        }
    }
}
