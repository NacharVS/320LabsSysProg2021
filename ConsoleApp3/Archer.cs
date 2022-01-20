using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Archer : Unit
    {
        private int _arrows;
        private double _dmg;
        public Archer()
        {
            Health = 75;
            _arrows = 5;
            _dmg = 30;
        }

        public void Attack(Unit unit)
        {
            if (_dmg >= 0 && _arrows > 0)
            {
                unit.Health -= _dmg;
                _arrows--;
            }
            else
            {
                Console.WriteLine("Ran out of arrows");
            }
        }
    }
}
