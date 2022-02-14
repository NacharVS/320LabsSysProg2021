using System;
using System.Collections.Generic;
using System.Text;
using UnitsInterfaces;

namespace UnitsClasses
{
	public abstract class Unit : IUnit
	{
		private double _health;
        internal double _maxHealth;
        private double _attackSpeed;
        private double _walkingSpeed;
        internal virtual bool IsCatapult { get => false; }
        
        public string Name;
        public delegate void HealthChangedDelegate(string message);

        protected Unit(string name, int health, int attackSpeed, int walkingSpeed)
        {
            Name = name;
            _health = health;
            _maxHealth = _health;
            _attackSpeed = attackSpeed;
            _walkingSpeed = walkingSpeed;
        }
        public double Health
        {
            get { return _health; }
            set
            {
                if (value > 0)
                {
                    HealthChangedEvent?.Invoke($"{Name}: Health changed ({value - _health})");
                    Console.WriteLine($"{Name}: Health changed ({value - _health})");
                    _health = value;
                }
                else
                {
                    _health = 0;
                    HealthChangedEvent?.Invoke($"{Name}: Unit died");
                    Console.WriteLine($"{Name}: Unit died");
                }
            }
        }
        public double AttackSpeed { get { return _attackSpeed; } set { _attackSpeed = value; } }
        public double WalkingSpeed { get { return _walkingSpeed; } set { _walkingSpeed = value; } }

        public event HealthChangedDelegate HealthChangedEvent;

        public override string ToString()
        {
            return $"{Name} Health: {Health}";
        }
    }
}