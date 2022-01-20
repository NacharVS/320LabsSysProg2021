using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Archer : BattleUnit
    {
        private int Arrows { get; set; }

        public Archer(string name): base(name, 45,1,10,3)
        {
            Arrows = 5;
        }

        public double RangeAttack()
        {
            if (Arrows > 0)
            {
                double presentDamage = (new Random()).Next(10,80);
                Arrows--;
                return presentDamage;
            }
            else
            {
                return MeleeAttack();
            }
        }
    }
}
