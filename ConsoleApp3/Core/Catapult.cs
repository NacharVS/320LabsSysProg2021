using ConsoleApp3.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Catapult : Unit
    {
        public int valuePatron;
        public Catapult(string name): base(name, 300, 50, 0.4, 10, true , 100)
        {
            valuePatron = 10;
        }

    }

    
}
