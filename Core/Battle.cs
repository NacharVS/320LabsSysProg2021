using System;
using System.Collections.Generic;
using System.Text;
using UnitInterfaces;

namespace Core
{
    public class Battle
    {
        public void Fighting(IBattleUnit unit1, IBattleUnit unit2)
        {
            while (unit1.Health > 0 && unit2.Health > 0)
            {
                unit1.Attack(unit2, unit1.Damage);
                unit2.Attack(unit1, unit2.Damage);

                unit1.Message();
                unit2.Message();
            }
        }

        public void Fighting(Archer arc, IBattleUnit unit)
        {
            while (arc.Health > 0 && unit.Health > 0)
            {
                arc.Health -= unit.MeleeAttack();
                unit.Health -= arc.RangeAttack();
                arc.Message();
                unit.Message();
            }
        }

        public void Fighting(Soldier sold, IBattleUnit unit)
        {
            while (sold.Health > 0 && unit.Health > 0)
            {
                sold.Attack(unit, sold.Damage);
                unit.Attack(sold, unit.Damage);

                sold.Message();
                unit.Message();
            }
        }

        public void Fighting(Building build, IBattleUnit unit)
        {
            if (unit.IsCatapult)
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
