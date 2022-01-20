using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Battle : MovingUnit
    {

        public Battle(string name, double health, double damage, int attackSpeed) : base(name, health, damage, attackSpeed)
        {

        }
        public virtual double Infighting()
        {
            return 5;
        }
    }
}
