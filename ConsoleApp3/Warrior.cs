using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : Unit
    {
        public void Attack(Unit unit, double damage)
        {
            if (damage >= 0)
                unit.Health -= damage;
        }

        public Warrior()
        {
            Health = 200;
        }

        public Warrior(double hp)
        {
            Health = hp;
        }
    }
}
