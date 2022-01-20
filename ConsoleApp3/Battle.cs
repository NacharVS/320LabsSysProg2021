using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Battle : Unit
    {
        public double attackSpeed;
        public double walkSpeed;

        public Battle(double attackSpeed, double walkSpeed) : base(50)
        {
            this.attackSpeed = attackSpeed;
            this.walkSpeed = walkSpeed;
        }
        public virtual double MelleeAttack()
        {
            return 5;
        }
    }
}
