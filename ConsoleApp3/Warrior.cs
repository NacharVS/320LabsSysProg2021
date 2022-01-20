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
                unit.Hp -= damage;

        }
        public Warrior()
        {
            Hp = 90;
        }
        public Warrior(double health)
        {
            Hp = health;
        }
    }
}
