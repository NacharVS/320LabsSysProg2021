using System;

namespace ConsoleApp3
{
    class Archer : RangeUnit
    {
        public Archer(string name) : base("Archer", name, 100) 
        {
            MleeDamage = 4;
            MleeAttackSpeed = 1000;

            RangeProjectileCount = 5;
            RangeDamage = 15;
            RangeAttackSpeed = 2000;
        }
    }
}
