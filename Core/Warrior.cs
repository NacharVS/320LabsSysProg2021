using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Warrior : BattleUnit
    {
        public Warrior(string name) : base(name, 200, 3, 10, 5) { }

        public override double MleeAttack()
        {
            if (!rage && Health > 0.4 * _maxHealth)
            {
                return base.MleeAttack();

            }
            else
            {
                rage = true;
                return base.MleeAttack() * 2;
            }
        }
    }
}
