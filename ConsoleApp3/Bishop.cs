using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Bishop : Battle
    {

        public Bishop(string name, double healCount) : base(name, 100, 10, 1, 2)
        {
            HealAmount = _healAmount;
        }

        public double _healAmount;
        public double HealAmount
        {
            get { return _healAmount; }
            set { _healAmount = value; }
        }

        public void Heal(Unit unit)
        {
            if (unit.Health + HealAmount >= unit.MaxHealth)
            {
                unit.Health = unit.MaxHealth;
            }
            else
            {
                unit.Health += HealAmount;
            }
        }

    }
}
