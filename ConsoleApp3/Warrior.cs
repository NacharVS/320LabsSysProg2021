using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : Unit
    {
        private int _damage;
        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        


        public Warrior()
        {
            Damage = 10;
        }


        public void Hit(Unit unit)
        {
            if (unit.Health - _damage < 0)
                unit.Health = 0;
            else
                unit.Health += -_damage;
        }
    }
}
