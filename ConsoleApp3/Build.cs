using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Build : Unit, IUnit
    {
        public Build()
        {
            name = "Build";
            Health = 1000;
        }
    }
}
