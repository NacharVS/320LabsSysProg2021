using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Soldier : Unit
    {
        public Soldier(string name) : base(name, 80,10,2,3)
        {

        }

        public double MeleeAttack()
        {
            return 1.5;
        }
    }
}
