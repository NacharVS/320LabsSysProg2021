using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Peasant : Unit
    {
        public Peasant()
        {
            Health = 50;
        }
        public Peasant(double hp)
        {
            Health = hp;
        }
    }
}
