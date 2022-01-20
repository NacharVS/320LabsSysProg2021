using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Archer : Battle
    {
        private int _arrows { get; set; }
        public Archer(string name) : base(name, 40, 10, 0, 4)
        {
            _arrows = 3;
        }

        public double RangeAttack()
        {
            return 3;
        }
    }
}
