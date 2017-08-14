using System.Linq;

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
