using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : Unit, IBattleUnit, IUnit
    {


        public int atack => 50;

        public Warrior()
        {
            Health = 70;
            name = "Warrior";
        }

        public void Damage (IUnit unit)
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
