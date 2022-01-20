using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Battle
    {
        public static void Fight(BattleUnit unit1, BattleUnit unit2)
        {
            while (unit1.Health > 0 && unit2.Health > 0)
            {
                unit1.Health -= unit2.MleeAttack(new Random());
                unit2.Health -= unit1.MleeAttack(new Random());
                unit1.Info();
                unit2.Info();
            }
        }
        public static void Fight(Building building, BattleUnit unit)
        {
            if (unit.IsCatapult)
            {
                while (building.Health > 0)
                {
                    if (building.Wall > 0)
                    {
                        building.Wall = building.Wall - unit.MleeAttack(new Random());
                        building.Info();
                        unit.Info();
                    }
                    else
                    {
                        building.Health = building.Health - unit.MleeAttack(new Random());
                        building.Info();
                        unit.Info();
                    }
                }
            }
            else
            {
                Console.WriteLine($"unit {unit.Name}can't attack this building ");
            }
        }
        public static void Fight(Archer archer, BattleUnit unit)
        {
            while (archer.Health > 0 && unit.Health > 0)
            {
                archer.Health = archer.Health - unit.MleeAttack(new Random()); 
                unit.Health -= archer.RangeAttack(new Random());
                archer.Info();
                unit.Info();

            }
        }

    }
}
