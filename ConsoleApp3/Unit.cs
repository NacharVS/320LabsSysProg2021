using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class Unit
    {
		public delegate void HealthChangedDelegate(string message);
		public event HealthChangedDelegate HealthChangedEvent;
		public string Name { get; private set; }
		internal virtual bool IsCatapult { get => false; }
		public Unit(string name, double health, double damage)
		{
			Name = name;
			Health = health;
			MaxHealth = health;
			Damage = damage;
			CreateUnit();
		}

        protected Unit(string name, double health)
        {
            Name = name;
            Health = health;
        }

        public void CreateUnit()
		{
			Console.WriteLine($"{Name} is created");
		}

		private double _maxHealth;

		public double MaxHealth
		{
			get { return _maxHealth; }
			set { _maxHealth = value;  }
		}

		private double _health;
		public double Health
		{
			get { return _health; }
			set
			{
				if (value > 0)
				{
					var presentHealth = Health;
					_health = value;
					HealthChangedEvent?.Invoke($"Health: {value}, changed to: {Health - presentHealth}");
				}
				else if (value > MaxHealth)
				{
					_health = MaxHealth;
				}
				else
				{
					_health = 0;
					HealthChangedEvent?.Invoke("Unit died");
				}
			}
		}

		private double _damage;

		public double Damage
		{
			get { return _damage; }
			set { _damage = value; }
		}

		public virtual void Message()
		{
			Console.WriteLine($"Name: {Name} - Health: {Health}");
		}

	}
}
