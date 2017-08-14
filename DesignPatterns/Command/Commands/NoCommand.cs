using System;

namespace Command.Commands
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("No command set");
        }
    }
}