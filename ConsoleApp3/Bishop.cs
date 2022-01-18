using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Bishop : Unit
    {
        public double HealAmount { get; set; }

        public Bishop(double hitPoints, double healthPower)
        {
            HealAmount = healthPower;
            this.Health = hitPoints;
        }
        public void Heal(Unit u)
        {
            if (u.Health > 0)
            {
                u.Health += this.HealAmount;
            }
        }
    }
}
