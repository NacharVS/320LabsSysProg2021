using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.GameUnits
{
    class Catapult : RangeAttackUnits
    {
        public override double MaxHealth => 600;
        public Catapult(string name) : base(name)
        {
            Health = 1000;
            Damage = 80;
            Speed = 3;
            AttackSpeed = 0.2;
            AttackRange = 60;
        }

        public override double GetDamage()
        {
            if (Shots > 0)
            {
                Shots--;
                return Damage;
            }
            else
            {
                AttackRange = 2;
                return Damage / 2;
            }
        }
    }
}
