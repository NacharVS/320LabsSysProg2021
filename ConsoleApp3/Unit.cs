using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class Unit
    {
        private double _health;
        public double Health
        {
            get { return _health; }
            set 
            {
                if(value >= 0)
                    _health = value;
            }
        }

        private double _damage;
        public double Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public double Hitting()
        { 
            
        }
    }
}
