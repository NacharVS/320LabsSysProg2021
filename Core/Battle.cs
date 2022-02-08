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
                unit1.Attack(unit2);
                unit2.Attack(unit1);

                unit1.Message();
                unit2.Message();
            }
        }

        public void Fighting(Archer arc, IBattleUnit unit)
        {
            while (arc.Health > 0 && unit.Health > 0)
            {
                arc.Attack(unit);
                unit.Attack(arc);
                arc.Message();
                unit.Message();
            }
        }

        public void Fighting(Soldier sold, IBattleUnit unit)
        {
            while (sold.Health > 0 && unit.Health > 0)
            {
                sold.Attack(unit);
                unit.Attack(sold);

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
                        unit.MeleeAttack(unit);                
                        build.Message();
                        unit.Message();
                    }
                    else
                    {
                        unit.MeleeAttack(unit);
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
