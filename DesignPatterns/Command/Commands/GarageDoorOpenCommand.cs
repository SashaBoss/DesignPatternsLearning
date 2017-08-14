using Command.Receivers;

namespace Command.Commands
{
    public class GarageDoorOpenCommand : ICommand
    {
        private readonly GarageDoor _garage;

        public GarageDoorOpenCommand(GarageDoor door)
        {
            _garage = door;
        }

        public void Execute()
        {
            _garage.OpenDoor();
        }
    }
}
