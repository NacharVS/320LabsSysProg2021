using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Bishop : Unit
    {
        public double HealAmount { get; set; }

        public Bishop()
        {
            Health = 50;
        }

        public Bishop(double hp)
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
