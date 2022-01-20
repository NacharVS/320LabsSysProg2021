using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : Battle
    {
        public Warrior(string name) : base(name, 100, 10, 5, 2)
        {

        }

        public override double Infighting()
        {
            return 2;
        }
    }
}
