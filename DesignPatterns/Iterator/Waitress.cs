﻿using System;
using System.Collections.Generic;

namespace Iterator
{
    public class Waitress
    {
        private readonly MenuComponent _allMenus;

        public Waitress(MenuComponent allMenus)
        {
            _allMenus = allMenus;
        }

        public void PrintMenu()
        {
           _allMenus.Print();
        }
    }
}
