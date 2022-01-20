using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Archer : Unit
    {
        private int _arrows;
        public Archer()
        {
            Health = 75;
            _arrows = 5;
        }

        public Archer(double hp)
        {
            Health = hp;
            _arrows = 5;
        }

        public void Attack(Unit unit, double dmg)
        {
            if (dmg >= 0 && _arrows > 0)
            {
                unit.Health -= dmg;
                _arrows--;
            }
            else
            {
                Console.WriteLine("Ran out of arrows");
            }
        }
    }
}
