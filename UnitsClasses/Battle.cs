using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using UnitsInterfaces;

namespace UnitsClasses
{
    public class Battle
    {
        public static void Fight(IBattleUnit firstUnit, IBattleUnit secondUnit)
        {
            while (firstUnit.Health * secondUnit.Health > 0)
            {
                firstUnit.Health -= secondUnit.Attack(new Random());

                if (firstUnit.Health == 0)
                    return;
                secondUnit.Health -= firstUnit.Attack(new Random());
            }
        }
        public static void Fight(IBattleUnit firstUnit, IBuilding building)
        {
            if (firstUnit.GetType() != (new Catapult()).GetType())
            {
                Console.WriteLine("Этот боец не может атаковать здание");
                return;
            }

            while (building.Health > 0)
            {
                if (building.Wall > 0)
                {
                    building.Wall -= firstUnit.Attack(new Random());
                }
                else
                { 
                    building.Health -= firstUnit.Attack(new Random());
                }
            }
            
        }

    }
}
