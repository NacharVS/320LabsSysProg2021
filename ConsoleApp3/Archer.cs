using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Archer : BattleUnit
    {
        private int _minRangeDamage;
        private int _maxRangeDamage;
        private int _arrows;

        public Archer(string name, double health, int AttackSpeed, double maxH, int min, int max) : base(name, health, AttackSpeed, maxH, min, max)
        {
            _minRangeDamage = 4;
            _maxRangeDamage = 12;
            _arrows = 5;
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
