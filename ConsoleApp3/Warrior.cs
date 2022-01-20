using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : Unit
    {
        public Warrior(double hitpoints, double attackSpeed, double walkingSpeed)
        {
            this.Health = hitpoints;
            this.AttackSpeed = attackSpeed;
            this.WalkingSpeed = walkingSpeed;
        }
    }
}
