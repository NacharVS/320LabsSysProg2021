using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Archer : UnitBattle
    {
        private int _arrows { get; set; }
        private int _rangeDamage;

        public Archer(string name) : base(name, 50, 5, 2, 2)
        {
            _arrows = 3;
            _rangeDamage = 15;
        }

        public double RangeAttack()
        {
            if (_arrows > 0)
            {
                double damage = (new Random()).Next((int)(_rangeDamage * 0.8), (int)(_rangeDamage * 1.2) + 1);
                --_arrows;
                return damage;
            }
            else
            {
                return Infighting();
            }
        }
        public override double Infighting()
        {
            if (!rage && Health > 0.6 * _maxHealth)
            {
                return base.Infighting();

            }
            else
            {
                rage = true;
                return base.Infighting() * 2;
            }
        }
    }
}
