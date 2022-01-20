using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Archery : Battle
    {
        public int Arrows { get; set; }
        public Archery() : base(10,5)
        {
            Arrows = 5;
        }

        public double RangeAttack()
        {
            return 5;
        }
    }
}
