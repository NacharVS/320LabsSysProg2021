using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Archer : RangeAttackUnits
    {
        public override double MaxHealth => 50;
        public Archer(string name) : base(name)
        {
            Health = 50;
            Damage = 25;
            Speed = 5;
            AttackSpeed = 1;
            Shots = 5;
            AttackRange = 50;
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
