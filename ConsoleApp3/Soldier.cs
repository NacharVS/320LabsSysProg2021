using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Soldier : BattleUnit
    {
        public Soldier(string name) : base(name,100,10,5,2)
        {

        }
        public override double MeleeAttack()
        {
            return 1.5;
        }
    }
}
