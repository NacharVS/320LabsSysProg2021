using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Archer : Unit
    {
        private int Arrows { get; set; }
        public Archer(string name): base(name, 45,10,0,2)
        {

        }
    }
}
