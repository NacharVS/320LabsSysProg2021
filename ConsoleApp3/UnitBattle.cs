using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class UnitBattle
    {
        public static void Fight(Battle unit1, Battle unit2)
        {
            while (unit1.Health > 0 && unit2.Health > 0)
            {
                unit1.Health -= unit2.Infighting();
                unit2.Health -= unit1.Infighting();
                unit1.Message();
                unit2.Message();
            }
        }
        public static void Fight(Archer archer, Battle unit)
        {
            while (archer.Health > 0 && unit.Health > 0)
            {
                archer.Health = archer.Health - unit.Infighting();
                //unit.Health -= archer.RangeAttack(new Random());
                archer.Message();
                unit.Message();

            }
        }
    }
}
