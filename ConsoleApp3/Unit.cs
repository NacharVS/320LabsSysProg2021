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
                if (_health - value < _health)
                    HealthChandgedEvent?.Invoke("Unit has been damaged: " + (value - _health) + "\n" + "Units health: " + value);
                else
                    HealthChandgedEvent?.Invoke("Unit has been healed: " + value + "\n" + "Units health: " + (_health + value));
                _health = value;
            }
        }
        private double _maxHealth;
        public double MaxHealth
        {
            get { return _maxHealth; }
            set { _maxHealth = value; }
        }


        public delegate void HealthChangedDelegate(string message);
        public event HealthChangedDelegate HealthChandgedEvent;
    }
}
