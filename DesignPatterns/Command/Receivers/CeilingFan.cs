﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Receivers
{
    public class CeilingFan
    {
        public static int HIGH = 3;
        public static int MEDIUM = 2;
        public static int LOW = 1;
        public static int OFF = 0;
        private string _location;
        private int _speed;

        public CeilingFan(string location)
        {
            _location = location;
            _speed = OFF;
        }

        public void High()
        {
            _speed = HIGH;
        }

        public void Medium()
        {
            _speed = MEDIUM;
        }

        public void Low()
        {
            _speed = LOW;
        }

        public void Off()
        {
            _speed = OFF;
        }

        public int GetSpeed()
        {
            return _speed;
        }
    }
}
