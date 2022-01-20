using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : Unit
    {
        
        private int _atack;
        public int Atack
        { 
            get { return _atack; }
            set { _atack = value; }
        }

        

        public Warrior()
        {
            Health = 70;
            Atack = 50;
            name = "Warrior";
        }

        public void Damage (Unit unit)
        {
            if (unit.name != "Build")
            {
                if (unit.Health - _atack > 0)
                    unit.Health -= _atack;
                else
                    unit.Health = 0;
            }
            else
                Console.WriteLine("only catapult can attack building");
        }
    }
}
