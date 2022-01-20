using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Catapult : BattleUnit
    {
        public override bool isCatapult => true;
        public Catapult() : base("Catapult", 210, 30, 4, 5)
        {

        }
    }
}
