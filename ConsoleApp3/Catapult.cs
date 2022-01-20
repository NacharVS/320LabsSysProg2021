using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Catapult : Unit
    {
        private int _atack;
        public int Atack
        {
            get { return _atack; }
            set { _atack = value; }
        }



        public Catapult()
        {
            Health = 70;
            Atack = 50;
            name = "Catapult";
        }

        public void Damage(Unit unit)
        {
            if (unit.Health - _atack > 0)
                unit.Health -= _atack;
            else
                unit.Health = 0;

        }
    }
}
