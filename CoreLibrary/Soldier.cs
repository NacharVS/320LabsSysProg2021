using System;

namespace CoreLibrary
{
    public class Soldier : Unit
    {
        public Soldier(string name) : base("Soldier", name, 100) 
        {
            MleeDamage = 10;
            MleeAttackDistance = 1;
            MleeAttackSpeed = 1000;

            WalkingSpeed = 1;
        }
    }
}
