using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3
{
    class Battle
    {
        public static void Fight(IUnitBattle unit1, IUnitBattle unit2)
        {
            while (unit1.Health > 0 && unit2.Health > 0)
            {
                unit1.Health -= unit2.MeleeAttack(new Random());
                unit2.Health -= unit1.MeleeAttack(new Random());
            }
        }
    }
}
