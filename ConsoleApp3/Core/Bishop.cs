using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Bishop : Unit
    {
        public Bishop()
        {
            HealPower = 5;
        }

        private double _healPower;
        public double HealPower
        {
            get { return _healPower; }
            set { _healPower = value; }
        }

        public void Heal(Unit unit)
        {
            if (unit.Health + _healPower >= unit.MaxHealth)
                unit.Health += unit.MaxHealth - unit.Health;
            else
                unit.Health += _healPower;
        }
    }
}
