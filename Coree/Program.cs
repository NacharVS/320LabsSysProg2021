using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coree.Interface;
using Coree.Units;

namespace Coree
{
    class Program
    {
        public string Fight(IBattleUnit unit1, IBattleUnit unit2)
        {
            string battleLog = "";
            while (unit1.Health > 0 && unit2.Health > 0)
            {
                unit1.Attack(unit2);
                unit2.Attack(unit1);
                battleLog += $"{unit1}{Environment.NewLine}{unit2}{Environment.NewLine}";
            }
            return battleLog;
        }

        public string Fight(IBattleUnit unit, IBuilding building)
        {
            string battleLog = "";
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
                battleLog = $"{unit.GetType().Name} cannot attack buildings";
            }
            return battleLog;
        }
    }
}
