using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Bishop : Unit
    {
        public double HealAmount { get; set; }

        public Bishop(double hitPoints, double healPower, double attackSpeed, double walkSpeed)
        {
            HealAmount = healPower;
            this.Health = hitPoints;
            this.AttackSpeed = attackSpeed;
            this.WalkingSpeed = walkSpeed;
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
