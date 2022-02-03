using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Battle
    {
        public void Fighting(BattleUnit unit1, BattleUnit unit2)
        {
            while (unit1.Health > 0 && unit2.Health > 0)
            {              
                unit1.Attack(unit1, unit2.MeleeAttack());
                unit2.Attack(unit2, unit1.MeleeAttack());
                //unit1.Health = unit1.Health - unit2.MeleeAttack();
                //unit2.Health = unit2.Health - unit1.MeleeAttack();
                unit1.Message();
                unit2.Message();
            }
        }

        public void Fighting(Archer arc, BattleUnit unit)
        {
            while (arc.Health > 0 && unit.Health > 0)
            {
                arc.Attack(arc, unit.MeleeAttack());
                unit.Attack(unit, arc.RangeAttack());
                //arc.Health -= unit.MeleeAttack(); 
                //unit.Health -= arc.RangeAttack();
                arc.Message();
                unit.Message();
            }
        }

        public void Fighting(Soldier sold, BattleUnit unit)
        {
            while (sold.Health > 0 && unit.Health > 0)
            {
                //sold.Attack(sold, unit.MeleeAttack());
                unit.Attack(unit, sold.MeleeAttack());

                //sold.Health -= unit.MeleeAttack();
                //unit.Health -= sold.MeleeAttack();
                //sold.Message();
                unit.Message();
            }
        }

        public void Fighting(Building build, BattleUnit unit)
        {
            if (unit.isCatapult)
            {
                while (build.Health > 0)
                {
                    if (build.Wall > 0)
                    {
                        build.Wall = build.Wall - unit.MeleeAttack();                
                        build.Message();
                        unit.Message();
                    }
                    else
                    {
                        build.Health = build.Health - unit.MeleeAttack();
                        build.Message();
                        unit.Message();
                    }
                }
            }
            else
            {
                Console.WriteLine($"Unit {unit.Name} can't attack");
            }
        }
    }
}
