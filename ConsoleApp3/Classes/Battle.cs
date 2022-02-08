using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Timers;

namespace ConsoleApp3
{
    public class Battle
    {
        string battleLog = "";
        public string Fight(IBattleUnit unit1, IBattleUnit unit2)
        {
            battleLog += $"{unit1.Name} has {unit1.Health}, {unit2.Name} has {unit2.Health} \n";
            while (unit1.Health > 0 && unit2.Health > 0)
            {
                unit1.Attack(unit2);
                unit2.Attack(unit1);
                battleLog += $"{unit1.Name} has {unit1.Health}, {unit2.Name} has {unit2.Health} \n";
            }
            return battleLog;
        }

        public string Fight(IBattleUnit unit, IBuilding building)
        {
            if (unit is Catapult)
            {
                while (unit.Health > 0 && building.Health > 0 && (unit as Catapult).Ammo > 0)
                {
                    unit.Attack(building);
                    battleLog += $"{unit}{Environment.NewLine}{building}{Environment.NewLine}";
                }
            }
            else
            {
                battleLog = $"{unit.GetType().Name} can't attack buildings";
            }
            return battleLog;
        }
    }
}
