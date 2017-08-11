using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var simpleControl = new SimpleRemoteControl();
            var light = new Light();

            simpleControl.SetCommand(new LightOnCommand(light));

            simpleControl.ButtonPress();

            simpleControl.SetCommand(new GarageDoorOpenCommand(new GarageDoor()));

            simpleControl.ButtonPress();

            Console.ReadLine();
        }
    }
}
