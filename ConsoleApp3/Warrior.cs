using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : Unit
    {
        public void Attack(Unit unit, double dmg)
        {
            if (dmg >= 0)
                unit.Health -= dmg;
        }
        public Warrior()
        {
            Health = 100;
        }
        public Warrior(double hp)
        {
            Health = hp;
        }
    }
}
