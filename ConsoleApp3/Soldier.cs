using System;

namespace ConsoleApp3
{
    class Soldier : Unit
    {
        public Soldier(string name) : base("Soldier", name, 100) 
        {
            MleeDamage = 10;
            MleeAttackDistance = 1;
            MleeAttackSpeed = 3000;

            WalkingSpeed = 1;
        }
    }
}
