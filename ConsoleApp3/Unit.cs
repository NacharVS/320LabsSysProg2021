using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class Unit
    {
        private double _health;
        public double Health
        {
            get { return _health; }
            set
            {
                _health = value;
            }
        }
    }
}
