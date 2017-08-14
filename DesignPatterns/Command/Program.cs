using System;
using Command.Commands;
using Command.Controllers;
using Command.Receivers;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var simpleControl = new SimpleRemoteControl();
            simpleControl.SetCommand(new LightOnCommand(new Light()));
            simpleControl.ButtonPress();
            simpleControl.SetCommand(new GarageDoorOpenCommand(new GarageDoor()));
            simpleControl.ButtonPress();

            var remoteControl = new RemoteControl();
            var stereo = new Stereo();
            var stereoOnCommand = new StereoOnWithCdCommand(stereo);
            var stereoOffCommand = new StereoOffCommand(stereo);

            remoteControl.SetCommand(0, stereoOnCommand, stereoOffCommand);

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);

            Console.WriteLine(remoteControl);

            Console.ReadLine();
        }
    }
}
