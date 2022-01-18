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
            Damage = 20;
        }

        public Peasant(double heal, double damage)
        {
            Health = heal;
            Damage = damage;
        }
    }
}
