using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Battle
    {
        public void Fight(BattleUnit battleUnit1, BattleUnit battleUnit2)
        {
            string battleLog = "";
            while (battleUnit1.Health > 0 && battleUnit2.Health > 0)
            {
                battleUnit1.Health += -battleUnit2.MeleeAttack();
                battleUnit2.Health += -battleUnit1.MeleeAttack();
                battleLog += $"{battleUnit1}{Environment.NewLine}{battleUnit2}{Environment.NewLine}";
            }
        }

        public void Fight(Archer archer, BattleUnit battleUnit)
        {
            string battleLog = "";
            while (archer.Health > 0 && battleUnit.Health > 0)
            {
                archer.Health += -battleUnit.MeleeAttack();
                battleUnit.Health += -archer.RangeAttack();
                battleLog += $"{archer}{Environment.NewLine}{battleUnit}{Environment.NewLine}";
            }
        }

        public void Fight(BattleUnit battleUnit, Archer archer)
        {
            string battleLog = "";
            while (archer.Health > 0 && battleUnit.Health > 0)
            {
                archer.Health += -battleUnit.MeleeAttack();
                battleUnit.Health += -archer.RangeAttack();
                battleLog += $"{archer}{Environment.NewLine}{battleUnit}{Environment.NewLine}";
            }
        }

        public void Fight(Archer archer1, Archer archer2)
        {
            string battleLog = "";
            while (archer1.Health > 0 && archer2.Health > 0)
            {
                archer1.Health += -archer2.RangeAttack();
                archer2.Health += -archer1.RangeAttack();
                battleLog += $"{archer1}{Environment.NewLine}{archer2}{Environment.NewLine}";
            }
        }

        public void Fight(Building building, BattleUnit battleUnit)
        {
            string battleLog = "";
            if (battleUnit.isCatapult)
            {
                while (building.Health > 0 && (battleUnit as Catapult).Projectiles > 0)
                {
                    if (building.Wall > 0)
                    {
                        building.Wall += -(battleUnit as Catapult).RangeAttack();
                        battleLog += $"{building}{Environment.NewLine}{battleUnit}{Environment.NewLine}";
                    }
                    else
                    {
                        building.Health += -(battleUnit as Catapult).RangeAttack();
                        battleLog += $"{building}{Environment.NewLine}{battleUnit}{Environment.NewLine}";
                    }
                }
            }
            else
            {
                battleLog = "This unit can't attack buildings";
            }
        }
    }
}
