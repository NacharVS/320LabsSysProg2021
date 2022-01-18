using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Bishop : Unit
    {
        public Bishop()
        {
            Health = 20;
            Damage = 2;
            HealCount = 10;
        }

        public Bishop(double heal, double healCount)
        {
            Health = heal;
            HealCount = healCount;
        }

        public double _healCount { get; set; }

        public double HealCount
        {
            get { return _healCount; }
            set { _healCount = value; }
            
        }
        public void Heal(Unit unit)
        {
            unit.Health += HealCount;
        }
    }
}
