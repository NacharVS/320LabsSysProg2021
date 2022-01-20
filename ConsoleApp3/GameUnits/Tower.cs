using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.GameUnits
{
    class Tower : Core.Building
    {
        public override double MaxHealth => 700;
        public Tower(string name) : base(name)
        {
            Health = 1000;
            Damage = 1;
            AttackSpeed = 0.5;
            AttackRange = 45;
            Wall = Health;
        }
    }
}
