using System;

namespace Command.Receivers
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
