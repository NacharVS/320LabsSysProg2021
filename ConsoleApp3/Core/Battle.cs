using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Battle
    {
        public static void Fight(UnitBattle unit1, UnitBattle unit2)
        {
            while (unit1.Health > 0 && unit2.Health > 0)
            {
                unit1.Health -= unit2.Infighting();
                unit2.Health -= unit1.Infighting();
                unit1.Message();
                unit2.Message();
            }
        }
        public static void Fight(Archer archer, UnitBattle unit)
        {
            while (archer.Health > 0 && unit.Health > 0)
            {
                archer.Health = archer.Health - unit.Infighting();
                unit.Health -= archer.RangeAttack();
                archer.Message();
                unit.Message();

            }
        }

        public static void Fight(UnitBattle unit, Archer archer)
        {
            while (archer.Health > 0 && unit.Health > 0)
            {
                archer.Health = archer.Health - unit.Infighting();
                unit.Health -= archer.RangeAttack();
                archer.Message();
                unit.Message();

            }
        }

        public static void Fight(Archer archer1, Archer archer2)
        {
            while (archer1.Health > 0 && archer2.Health > 0)
            {
                archer1.Health -= archer2.RangeAttack();
                archer2.Health -= archer1.RangeAttack();
                archer1.Message();
                archer2.Message();
            }
        }
    }
}
