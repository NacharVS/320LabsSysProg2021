using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3.Core
{
    class Catapult : UnitBattle, IUnitBattle
    {
        internal override bool IsCatapult => true;
        public Catapult(string name, double health, int attackSpeed, int walkingSpeed, int min, int max) : base(name, health, attackSpeed, walkingSpeed, min, max)
        {

        }
        public override void Message()
        {
            Console.WriteLine($"Catapult {Name} has {Health}hp");
        }
    }
}
