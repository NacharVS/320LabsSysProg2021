using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Peasant : Unit
    {
        public Peasant() 
        {
            Hp = 20;
            ASpeed = 0;
            WSpeed = 20;
        }
        public Peasant(double health) 
        {
            Hp = health;
        }
    }
}
