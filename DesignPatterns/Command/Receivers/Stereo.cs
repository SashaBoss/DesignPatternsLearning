using System;

namespace Command.Receivers
{
    public class Stereo
    {
        private string _cd;
        private int _volume;

        public void On()
        {
            Console.WriteLine("Stereo on");
        }

        public void Off()
        {
            Console.WriteLine("Stereo off");
        }

        public void SetCd(string cd)
        {
            _cd = cd;
            Console.WriteLine($"Playing {_cd}");
        }

        public void SetVolume(int volume)
        {
            _volume = volume;
            Console.WriteLine($"Volume is {_volume}");
        }
    }
}
