using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : BattleUnit
    {
        public Warrior(string name) : base(name, 100, 3, 8, 5) { }

        public override double MeleeAttack()
        {
            if (!rage && Health > 0.4 * MaxHealth)
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
