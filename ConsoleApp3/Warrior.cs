using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : Unit
    {
        public Warrior(double hitPoints, double hitDamage, string name)
        {
            Health = hitPoints;
            AttackValue = hitDamage;
            Name = name;
            //this.AttackSpeed = attackSpeed;
            //this.WalkingSpeed = walkingSpeed;
        }
    }
}
