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
        public int Armor { get; set; }
        public string Name;
        public delegate void HealthChangedDelegate(string message);

        protected Unit(string name, int health, int armor)
        {
            Name = name;
            _health = health;
            Armor = armor;
            _maxHealth = _health;
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

        public event HealthChangedDelegate HealthChangedEvent;

        public virtual void Info()
        {
            Console.WriteLine($"{Name} Health: {Health}");
        }
    }
}