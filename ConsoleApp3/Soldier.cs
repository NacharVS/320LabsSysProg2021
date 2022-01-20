using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Soldier : Battle
    {
        public Soldier() : base(5, 10)
        {

        }
        public override double MelleeAttack()
        {
            return 2;
        }
    }
}
