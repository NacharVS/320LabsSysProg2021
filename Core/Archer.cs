using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Archer : BattleUnit
    {
        private int Arrows { get; set; }

        public Archer(string name): base(name, 45,1,10,2)
        {
            Arrows = 5;
        }

        public double RangeAttack()
        {
            return 5;
        }
    }
}
