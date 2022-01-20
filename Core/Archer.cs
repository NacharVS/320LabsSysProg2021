using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Archer : BattleUnit
    {
        private int _arrows;
        private int _rangeDamage;

        public Archer(string name) : base(name, 50, 5, 2, 2)
        {
            _arrows = 5;
            _rangeDamage = 10;
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
                return MeleeAttack();
            }
        }

        public override double MeleeAttack()
        {
            if (!rage && Health > 0.6 * _maxHealth)
            {
                return base.MeleeAttack();

            }
            else
            {
                rage = true;
                return base.MeleeAttack() * 2;
            }
        }
    }
}
