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

        public delegate void HealthChangedDelegate(string message);
        public event HealthChangedDelegate HealthChandgedEvent;


        public Warrior()
        {
            Damage = 10;
        }


        public void Hit(Unit unit)
        {
            unit.Health -= _damage;
            if (unit.Health < 0)
                unit.Health = 0;
            HealthChandgedEvent?.Invoke("Peasant has been damaged: -" + _damage + "\n" + "Peasants health: " + unit.Health);
        }
    }
}
