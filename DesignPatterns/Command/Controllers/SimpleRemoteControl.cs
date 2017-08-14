using Command.Commands;

namespace Command.Controllers
{
    public class SimpleRemoteControl
    {
        private ICommand _slot;

        public void SetCommand(ICommand command)
        {
            _slot = command;
        }

        public void ButtonPress()
        {
            _slot.Execute();
        }
    }
}
