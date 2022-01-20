using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
	abstract class Unit
	{
		private double _health;
        private double _attackSpeed;
        private double _walkingSpeed;
        internal virtual bool IsCatapult { get => false; }
        internal double _maxHealth;
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
                    _health = value;
                }
                else
                {
                    _health = 0;
                    HealthChangedEvent?.Invoke($"{Name}: Unit died");
                }
            }
        }
        public double AttackSpeed { get { return _attackSpeed; } set { _attackSpeed = value; } }
        public double WalkingSpeed { get { return _walkingSpeed; } set { _walkingSpeed = value; } }


        public event HealthChangedDelegate HealthChangedEvent;

        public virtual void Info()
        {
            Console.WriteLine($"{Name} Health: {Health}");
        }
    }
}