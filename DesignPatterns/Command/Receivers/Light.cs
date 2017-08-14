using System;

namespace Command.Receivers
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Light on");
        }

        public void Off()
        {
            Console.WriteLine("Light off");
        }
    }
}