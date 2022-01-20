using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Bishop : MovingUnit
    {

        public Bishop(string name, double health, double damage, double heal) : base(name, health, damage)
        {
            HealAmount = heal;
        }

        public double _healAmount;
        public double HealAmount
        {
            get { return _healAmount; }
            set { _healAmount = value; }
        }

        public void Heal(Unit unit)
        {
            if (unit.Health + HealAmount >= unit._maxHealth)
            {
                unit.Health = unit._maxHealth;
            }
            else
            {
                unit.Health += HealAmount;
            }
        }

    }
}
