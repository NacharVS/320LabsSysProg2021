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
                firstUnit.Health -= secondUnit.MeleeAttack(new Random());
                secondUnit.Health -= firstUnit.MeleeAttack(new Random());
            }
        }
    }    
}
