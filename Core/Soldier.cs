using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Soldier : BattleUnit
    {
        public Soldier(string name) : base(name,100,10,5,2)
        {

        }
        public override double MeleeAttack()
        {
            if ( Health > 0.4 * MaxHealth)
            {
                return base.MeleeAttack();

            }
            else
            {
                return base.MeleeAttack() * 2;
            }
        }
    }
}
