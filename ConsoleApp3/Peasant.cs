using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Peasant : Unit, IUnit
    {
        public Peasant()
        {
            Health = 300;
            name = "Мирный житель";
        }

    }
}
