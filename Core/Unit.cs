using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
	public abstract class Unit
    {		
		public delegate void HealthChangedDelegate(string mes);
		public event HealthChangedDelegate HealtChangedEvent;
		public string Name { get; private set; }
		public virtual bool isCatapult => false;

		public Unit(string name,double health)
        {
			Name = name;
			Health = health;
			MaxHealth = health;
			
			Create();
		}

		public void Create()
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
				double present = Health;
				if (value > 0)
				{
					_health = value;
					HealtChangedEvent?.Invoke($"Health: {_health}, difference: {Health-present}");
				}
				else if (value > MaxHealth)
                {
					_health = MaxHealth;
					HealtChangedEvent?.Invoke($"Health: {_health}, difference: {Health - present}");
				}
				else
				{
					_health = 0;
					HealtChangedEvent?.Invoke($"Unit {Name} died");
				};
			}
		}

		public virtual void Message()
        {
			Console.WriteLine($"Name: {Name}, health: {Health}");
        }

	}
}
