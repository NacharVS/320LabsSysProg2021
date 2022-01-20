using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Building : Unit
    {
        public Building()
        {
            Health = 150;
        }

        public Building(double hp)
        {
            Health = hp;
        }
    }
}