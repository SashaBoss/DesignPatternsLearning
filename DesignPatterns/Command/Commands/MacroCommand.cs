using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class MacroCommand : ICommand
    {
        private readonly ICommand[] _commands;

        public MacroCommand(ICommand[] commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            _commands.ToList().ForEach(c => c.Execute());
        }

        public void Undo()
        {
            _commands.ToList().ForEach(c => c.Undo());
        }
    }
}
