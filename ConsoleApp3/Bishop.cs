using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Bishop : Unit
    {
        private double _heal;

        public Bishop()
        {
            Health = 50;
            _heal = 35;
        }
        public double HealCount
        {
            get { return _heal; }
            set { _heal = value; }

        }
        public void Heal(Unit unit)
        {
            if (unit.Health + HealCount >= unit.MaxHealth)
            {
                unit.Health = unit.MaxHealth;
            }
            else
            {
                unit.Health += HealCount;
            }

        }
    }
}
