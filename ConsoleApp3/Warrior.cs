using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : Unit
    {
        public Warrior()
        {
            Health = 90;
            Damage = 20;
        }

        public Warrior(double heal, double dam)
        {
            Health = heal;
            Damage = dam;
        }
        
    }
}
