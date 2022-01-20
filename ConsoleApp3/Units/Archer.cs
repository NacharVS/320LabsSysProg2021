using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Archer : Unit
    {
        private int Arrows { get; set; }
        public Archer(string name, int arrow) : base(name, 45, 10, 0, 2)
        {
            Arrows = arrow;
        }

        //public double RangeAttack()
        //{
        //    ///
        //}
    }
}
