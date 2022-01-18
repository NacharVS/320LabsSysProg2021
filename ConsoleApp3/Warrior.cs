using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : Unit
    {
        public Warrior()
        {
            Health = 40;
            Damage = 10;
        }

        public Warrior(double heal, double damage)
        {
            Health = heal;
            Damage = damage;
        }
    }
}

