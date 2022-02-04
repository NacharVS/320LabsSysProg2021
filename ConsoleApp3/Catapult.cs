using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Catapult : Unit, IUnit, IBattleUnit
    {
        



        public Catapult()
        {
            Health = 70;
            name = "Catapult";
        }

        public int atack => 50;

        public void Damage(IUnit unit)
        {
            if (unit.Health - atack > 0)
                unit.Health -= atack;
            else
                unit.Health = 0;

        }

        
    }
}
