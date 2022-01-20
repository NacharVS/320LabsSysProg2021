using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Bishop : Unit
    {
        public double HealAmount { get; set; }

        public Bishop():base(50)
        {
            Health = 20;
        }
        public Bishop(double hp):base(50)
        {
            Health = hp;
        }

        public double Heal(Unit unit, double heal)
        {
            unit.Health += heal;
            return HealAmount;
        }
    }
}
