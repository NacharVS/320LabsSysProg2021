using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Soldier : Unit
    {
        private int _atack;
        public int Atack
        {
            get { return _atack; }
            set { _atack = value; }
        }


        public Soldier()
        {
            name = "Soldier";
            Health = 100;
            Atack = 20;
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
