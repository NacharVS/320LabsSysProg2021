using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Peasant : Unit, UnitInterface.IMovebleUnit
    {
        public int WalkSpeed => 15;
        public void move() 
        {
        }
        public Peasant() 
        {
            Hp = 20;
        }
        public Peasant(double health) 
        {
            Hp = health;
        }
    }
}
