using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Cleric : Character
    {
        public double Healing { get; set; }
        public Cleric() : base(80, 3)
        {
            Healing = 10;
        }
    }
}
