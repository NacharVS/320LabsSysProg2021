using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : Unit
    {
        public Warrior():base(50)
        {
            Health = 200;
        }

        public Warrior(double hp):base(50)
        {
            Health = hp;
        }
    }
}
