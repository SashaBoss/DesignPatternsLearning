using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class GarageDoor
    {
        public void OpenDoor()
        {
            Console.WriteLine("Door opened");
        }

        public void OnGarageLight()
        {
            Console.WriteLine("Garage light on");
        }
    }
}
