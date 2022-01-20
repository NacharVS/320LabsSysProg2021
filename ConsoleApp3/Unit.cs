using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class Unit
    {
		public delegate void HealthChangedDelegate(string message);
		public string Name { get; private set; }

		public Unit(string name, double health, double damage)
		{
			Name = name;
			Health = health;
			Damage = damage;
			CreateUnit();
		}

		public void CreateUnit()
		{
			Console.WriteLine($"{Name} is created");
		}


		private double _health;
		public double Health
		{
			get { return _health; }
			set
			{
				if (value > 0)
				{
					_health = value;
					HealthChangedEvent?.Invoke("Health has changed");
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


		public event HealthChangedDelegate HealthChangedEvent;

		public void Attack(Unit unit)
		{
			unit.Health -= Damage;
		}

	}
}
