using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Bishop : MovableUnit
    {
        private double _healAmount;
        public double HealAmount
        {
            get { return _healAmount; }
            set { _healAmount = value; }
        }

        public Bishop(string name, double health, double damage, double heal) : base(name, health, damage)
        {
            HealAmount = heal;
        }

        public void Heal(Unit unit)
        {
            unit.Health += HealAmount;
        }
    }
}
