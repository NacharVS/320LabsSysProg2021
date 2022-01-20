using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Archer : BattleUnit
    {
        private int _arrows;
        private int _minRangeDamage;
        private int _maxRangeDamage;

        public Archer(string name, double health, int Attackspeed, double maxH, int min, int max) : base(name, health,  Attackspeed, maxH, min, max)
        {
            _arrows = 5;
            _minRangeDamage = 4;
            _maxRangeDamage = 12;
        }

        public double RangeAttack(Random rnd)
        {
            if (_arrows > 0)
            {
                double currentDamage = Convert.ToDouble(rnd.Next(_minRangeDamage, _maxRangeDamage));
                return currentDamage;
            }
            else
            {
                return MleeAttack(rnd);
            }

        }
    }
}
