using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Soldier : Unit, IUnit, IBattleUnit
    {
        


        public Soldier()
        {
            name = "Soldier";
            Health = 100;
        }

        public int atack => 20;

        public void Damage(IUnit unit)
        {
            if (unit.name != "Build")
            {
                if (unit.Health - atack > 0)
                    unit.Health -= atack;
                else
                    unit.Health = 0;
            }
            else
                Console.WriteLine("only catapult can attack building");
        }

    }
}
