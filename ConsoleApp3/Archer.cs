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

        public Archer(string name, int health, int attackSpeed, int walkingSpeed) : base(name, health, attackSpeed, walkingSpeed, 1, 2)
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
                _arrows--;
                return currentDamage;
            }
            else
            {
                return MleeAttack(rnd);
            }

        }
        public override void Info()
        {
            Console.WriteLine($"{Name} Health: {Health} Arrows: {_arrows}");
        }
    }
}
