using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Catapult : BattleUnit
    {
        internal override bool IsCatapult => true;

        public Catapult() : base("Catapult", 200, 20, 4, 30, 90)
        {
        }

        public override void Info()
        {
            Console.WriteLine($"{Name} Health: {Health}");
        }
    }
}
