using Command.Receivers;

namespace Command.Commands
{
    public class StereoOnWithCdCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOnWithCdCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.On();
            _stereo.SetCd("Best of Techno");
            _stereo.SetVolume(100);
        }

        public void Undo()
        {
            throw new System.NotImplementedException();
        }
    }
}
