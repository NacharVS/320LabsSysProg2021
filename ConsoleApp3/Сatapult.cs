using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Сatapult : Unit
    {
        public Сatapult()
        {
            Health = 70;
            Damage = 30;
        }

        public Сatapult(double heal, double damage)
        {
            Health = heal;
            Damage = damage;
        }
    }
}
