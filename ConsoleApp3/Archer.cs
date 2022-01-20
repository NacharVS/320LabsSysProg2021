using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Archer : Battle
    {
        private int _arrows { get; set; }
        public Archer(string name, double health, double damage, int attackSpeed) : base(name, health, damage, attackSpeed)
        {
            _arrows = 3;
        }

        public double RangeAttack()
        {
            if (_arrows > 0)
            {
                return 3;
            }
            else
            {
                return Infighting();
            }
        }
    }
}
