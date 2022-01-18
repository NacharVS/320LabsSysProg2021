using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class Unit
    {
        public delegate void HealthChangedDelegate(string message);
        private double _health;
        public double Health
        {
            get { return _health; }
            set { _health = value; }
        }
        public event HealthChangedDelegate HealthChandgedEvent;

        private double _damage;
        public double Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public void Hit(Unit unit)
        {
            unit.Health -= this.Damage;
            if (unit.Health < 0)
                unit.Health = 0;
            HealthChandgedEvent?.Invoke("Damage: -" + this.Damage + "\n" + "Health: " + unit.Health);
        }
    }
}
