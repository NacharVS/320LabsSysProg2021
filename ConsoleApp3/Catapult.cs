using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Catapult: BattleUnit
    {
        internal override bool IsCatapult => true;
        public Catapult(string name, double health, double attackPoint): base ("Catapult", health, 5,300,100, 200)
        
        {
            Name = name;
            Health = health;
            DamagePoint = attackPoint;
        }
        public override void Info()
        {
            Console.WriteLine($"Catapult {Name} has {Health}hp");
        }
    }
}
