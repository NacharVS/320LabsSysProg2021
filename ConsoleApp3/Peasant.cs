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
            Damage = 10;
        }

        public Peasant(double hp, double d)
        {
            Health = hp;
            Damage = d;
        }
    }
}
