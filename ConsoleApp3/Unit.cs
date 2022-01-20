using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class Unit
    {		
		public delegate void HealthChangedDelegate(string mes);
		public event HealthChangedDelegate HealtChangedEvent;
		public string Name { get; private set; }
	

		public Unit(string name,double health, double damage)
        {
			Name = name;
			Health = health;
			MaxHealth = health;
			Damage = damage;
			
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
				if (value > 0)
				{
					double present = Health;
					_health = value;
					HealtChangedEvent?.Invoke($"Health: {_health}, difference: {Health-present}");
				}
				else if (value > MaxHealth)
                {
					_health = MaxHealth;
                }
				else
				{
					_health = 0;
					HealtChangedEvent?.Invoke($"Unit died");
				};
			}
		}

		private double _damage;
		public double Damage
		{
			get { return _damage; }
			set { _damage = value; }
		}

		public void Attack(Unit unit)
		{
			unit.Health -= Damage;
		}

	}
}
