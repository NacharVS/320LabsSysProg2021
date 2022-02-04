using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Interfaces
{
    interface IUnit
    {
        public double Health { get; set; }
        public double maxHealth { get; set; }

        void createUnit(string name);
        
    }
}
