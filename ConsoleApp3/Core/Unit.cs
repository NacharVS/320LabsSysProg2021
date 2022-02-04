using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Unit : Interfaces.IUnit
    {
        public Unit()
        {
            _health = 100;
            _maxHealth = 100;
        }

        public Unit(string name, double health)
        {
            Name = name;
            Health = health;
            _maxHealth = health;
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private double _health;
        public double Health
        {
            get { return _health; }
            set
            {
                if (value >= 0)
                {
                    HealthChandgedEvent?.Invoke(Name + "'s health has been changed: " + (value - _health) + "\n" + "Units health: " + value);
                    _health = value;
                }
                else
                {
                    HealthChandgedEvent?.Invoke(Name + "'s health has been changed: " + (value - _health) + "\n" + "Units health: " + 0);
                    _health = 0;
                }
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
