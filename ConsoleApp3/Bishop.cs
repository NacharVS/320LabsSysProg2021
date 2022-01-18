using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Bishop : Unit
    {
        private double _healAmount;
        public double HealAmount
        {
            get { return _healAmount; }
            set { _healAmount = value; }
        }

        public Bishop()
        {
            Health = 100;
            HealAmount = 10;
        }
        public void HealUnit(Unit unit)
        {
            unit.Health += HealAmount;
        }

        
    }
}
