using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
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
