using System.Text;
using Command.Commands;

namespace Command.Controllers
{
    public class RemoteControl
    {
        private const int ButtonsCount = 7;
        private readonly ICommand[] _onCommands;
        private readonly ICommand[] _offCommands;
        private ICommand _undoCommand;

        public RemoteControl()
        {
            _onCommands = new ICommand[ButtonsCount];
            _offCommands = new ICommand[ButtonsCount];

            var noCommand = new NoCommand();
            for (int i = 0; i < ButtonsCount; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
            _undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }

        public void UndoButtonWasPushed()
        {
            _undoCommand.Undo();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Remote Controll\n");
            for (int i = 0; i < ButtonsCount; i++)
            {
                sb.Append(
                    $"slot {i} : onCommand : {_onCommands[i].GetType().Name}\t offComand : {_offCommands[i].GetType().Name}\n");
            }

            return sb.ToString();
        }
    }
}
