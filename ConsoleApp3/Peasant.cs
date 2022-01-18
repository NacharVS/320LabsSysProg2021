using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Peasant : Unit
    {
        public Peasant()
        {
            Health = 90;
            Damage = 100;
        }
        public Peasant(double heal, double dam)
        {
            Health = heal;
            Damage = dam;
        }
    }
}
