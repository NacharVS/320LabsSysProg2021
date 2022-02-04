using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Catapult: BattleUnit, IBattleUnit
    {
        internal override bool IsCatapult => true;
        public Catapult(): base ("Catapult", 200, 5,300,100, 200)
        {
           
        }
        public override void Info()
        {
            Console.WriteLine($"Catapult {Name} has {Health}hp");
        }
    }
}
