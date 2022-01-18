using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : Unit
    {
        public Warrior()
        {
            Health = 200;
        }

        public Warrior(double hp)
        {
            Health = hp;
        }
    }
}
