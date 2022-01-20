using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Archer : Unit
    {
        private int _atack;

        public int arrows = 5;
        public int Atack
        {
            get { return _atack; }
            set { _atack = value; }
        }



        public Archer()
        {
            Health = 40;
            Atack = 10;
            name = "Archer";
        }

        public void Damage(Unit unit)
        {

            if (unit.Health - _atack > 0)
            {
                unit.Health -= _atack;
                arrows--;
            }
            else
            {
                unit.Health = 0;
                arrows--;
            }
           
        }
    }
}
