using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Archer : BattleUnit
    {
        private int Arrows { get; set; }
        public Archer(string name): base(name, 45,10,0,2)
        {
            Arrows = 5;
        }

        public double RangeAttack()
        {
            return 5;
        }
    }
}
