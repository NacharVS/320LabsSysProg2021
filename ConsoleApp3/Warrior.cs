using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : Battle
    {
        public Warrior(string name, double health, double damage, int attackSpeed) : base(name, health, damage, attackSpeed)
        {

        }

        public override double Infighting()
        {
            return 5;
        }
    }
}
