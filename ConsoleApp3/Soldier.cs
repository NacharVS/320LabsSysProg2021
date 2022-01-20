using System;

namespace ConsoleApp3
{
    class Soldier : Unit
    {
        public Soldier(string name) : base("Soldier", name, 100) 
        {
            MleeDamage = 10;
            MleeAttackSpeed = 1500;
        }
    }
}
