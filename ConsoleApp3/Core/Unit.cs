using System;
using ConsoleApp3.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Unit : IUnit
    {
		

		public Unit(string name, double health, int attackSpeed, int walkingSpeed)
		{
			Name = name;
			Health = health;
			_maxHealth = health;
			AttackSpeed = attackSpeed;
			WalkingSpeed = walkingSpeed;
			CreateUnit();
		}

		public delegate void HealthChangedDelegate(string message);
		public event HealthChangedDelegate HealthChangedEvent;
		internal virtual bool IsCatapult { get => false; }

		private string _name;
		private double _attackSpeed;
		private double _walkingSpeed;

		public double AttackSpeed { get { return _attackSpeed; } set { _attackSpeed = value; } }
		public double WalkingSpeed { get { return _walkingSpeed; } set { _walkingSpeed = value; } }

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		public void CreateUnit()
		{
			Console.WriteLine($"{Name} is created");
		}

		private double _health;

		public double _maxHealth;
		public double Health
		{
			get { return _health; }
			set
			{
				if (value > 0)
				{
					var pastHealth = Health;
					_health = value;
					HealthChangedEvent?.Invoke($"{Name} - health: {value}, changed to: {Health - pastHealth}");
				}
				else if (value > _maxHealth)
				{
					_health = _maxHealth;
				}
				else
				{
					_health = 0;
					HealthChangedEvent?.Invoke($"{Name} died");
				}
			}
		}

		private double _damage;

		public double Damage
		{
			get { return _damage; }
			set { _damage = value; }
		}

        public void DamageUnit(Unit unit)
		{
			unit.Health -= Damage;
		}

		public virtual void Message()
		{
			Console.WriteLine($"Name: {Name} - Health: {Health}");
		}

	}
}
