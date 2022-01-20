using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3.Models
{
    internal class Catapult : Character
    {
        public void AttackBuilding(Building building)
        {
            if (building.Wall > 0)
                building.Wall -= Damage;
            else if(building.Health > 0)
                building.Health -= Damage;
        }

        internal Catapult()
        {
            Health = 600;
            Damage = 71;
            WalkSpeed = 25;
            AttackRange = 150;
        }
    }
}
