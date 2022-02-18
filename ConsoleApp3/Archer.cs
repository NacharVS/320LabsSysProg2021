using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Archer : Unit, IBattleUnit, IUnit
    {
        

        public int arrows = 5;


        public int atack => 10;

        public Archer()
        {
            Health = 40;
            name = "Archer";
        }

        public void Damage(IUnit unit)
        {
            if (unit.name != "Build")
            {
                if (unit.Health - atack > 0)
                {
                    unit.Health -= atack;
                    arrows--;
                }
                else
                {
                    unit.Health = 0;
                    arrows--;
                }
            }
            else
                Console.WriteLine("only catapult can attack building");
        }

       
    }
}
