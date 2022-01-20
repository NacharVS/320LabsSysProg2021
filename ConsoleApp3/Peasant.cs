using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Peasant : Unit
    {
        public Peasant():base(100)
        {
            Health = 50;
        }

        public Peasant(double hp):base(100)
        {
            Health = hp;
        }
    }
}
