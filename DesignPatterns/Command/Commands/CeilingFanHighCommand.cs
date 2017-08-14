using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receivers;

namespace Command.Commands
{
    public class CeilingFanHighCommand : ICommand
    {
        private readonly CeilingFan _fan;
        private int _prevSpeed;

        public CeilingFanHighCommand(CeilingFan fan)
        {
            _fan = fan;
        }

        public void Execute()
        {
            _prevSpeed = _fan.GetSpeed();
            _fan.High();
        }

        public void Undo()
        {
            if (_prevSpeed == CeilingFan.HIGH)
            {
                _fan.High();
            } else if(_prevSpeed == CeilingFan.MEDIUM)
            {
                _fan.Medium();
            } else if (_prevSpeed == CeilingFan.LOW)
            {
                _fan.Low();
            } else if (_prevSpeed == CeilingFan.OFF)
            {
                _fan.Off();
            }
        }
    }
}
