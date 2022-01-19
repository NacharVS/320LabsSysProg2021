using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : Unit
    {
        public Warrior()
        {
            Health = 100;
            Damage = 20;
        }

        public Warrior(double hp, double d)
        {
            Health = hp;
            Damage = d;
        }
    }
}
