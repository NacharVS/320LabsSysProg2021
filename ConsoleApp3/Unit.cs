using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class Unit
    {
		public delegate void HealthChangedDelegate(string mes);
		public event HealthChangedDelegate HealthChangedEvent;

		private double _health;
		private double _maxHealth;
		private double _damage;
		private string _name;

		protected Unit(string name, double health)
		{
			Name = name;
			Health = health;
			MaxHealth = health;
			Creation();
		}
		public void Creation()
		{
			Console.WriteLine($"Unit {Name} is created and has {Health}hp");
		}
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public double Health
		{
			get { return _health; }
			set {	if (value > 0)
					{
						_health = value;
						HealthChangedEvent?.Invoke($"Health: {value}, Changed to: {value - Health}");
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

		public double MaxHealth
		{
			get { return _maxHealth; }
			set { _maxHealth = value; }

		}

		public double Damage
		{
			get { return _damage; }
			set { _damage = value; }
		}

		public void Attack(Unit unit)
		{
			unit.Damage -= Damage;
		}

		public virtual void Info()
		{
			Console.WriteLine($" Unit {Name} has {Health}hp");
		}
	}
}
