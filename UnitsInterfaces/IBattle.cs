using System;
using System.Collections.Generic;
using System.Text;

namespace UnitsInterfaces
{
    public interface IBattle
    {
        void Fight(IBattleUnit firstUnit, IBattleUnit secondUnit)
        {
            while (firstUnit.Health * secondUnit.Health > 0)
            {
                firstUnit.Health -= secondUnit.MeleeAttack(new Random());
                secondUnit.Health -= firstUnit.MeleeAttack(new Random());
            }
        }
    }
}
