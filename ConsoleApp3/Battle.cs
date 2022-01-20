using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Battle
    {
        public void Fighting(BattleUnit unit1, BattleUnit unit2)
        {
            while (unit1.Health > 0 && unit2.Health > 0)
            {
                unit1.Attack(unit2);              
                unit2.Attack(unit1);
                unit1.Message();
                unit2.Message();
            }
        }
    }
}
