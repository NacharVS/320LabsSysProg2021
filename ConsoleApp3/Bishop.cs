using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Bishop : Unit
    {
        public double HealAmount { get; set; }
        private double _heal;

        public Bishop()
        {
            Health = 50;
            _heal = 35;
        }

        public double Heal(Unit unit)
        {
            unit.Health += _heal;
            return HealAmount;
        }
    }
}
