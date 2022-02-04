using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Battle
    {
        public void Fight(IBattleUnit unit1, IBattleUnit unit2)
        {
            while (unit1.health > 0 && unit2.health > 0)
            {
                if (unit2.health != 0)
                {
                    unit1.Attack(unit2, unit1.damage);
                }
                if (unit2.health != 0)
                {
                    unit2.Attack(unit1, unit2.damage);
                }
            }
        }
    }
}
