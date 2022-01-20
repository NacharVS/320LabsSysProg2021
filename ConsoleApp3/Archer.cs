using System;

namespace ConsoleApp3
{
    class Archer : RangeUnit
    {
        public Archer(string name) : base("Archer", name, 100) 
        {
            MleeDamage = 4;
            MleeAttackDistance = 1;
            MleeAttackSpeed = 1000;

            WalkingSpeed = 1.5;

            RangeProjectileCount = 5;
            RangeDamage = 15;
            RangeAttackDistance = 8;
            RangeAttackSpeed = 2000;
        }
    }
}
