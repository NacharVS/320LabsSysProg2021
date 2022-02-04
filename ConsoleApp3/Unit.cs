using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public abstract class Unit : IUnit
    {
		protected Unit(string name, double health, int attackSpeed, int walkingSpeed)
		{
			Name = name;
			Health = health;
			MaxHealth = health;
			AttackSpeed = attackSpeed;
			WalkingSpeed = walkingSpeed;
			Creation();
		}
		public void Creation()
		{
			Console.WriteLine($"Unit {Name} is created and has {Health}hp");
		}
		internal virtual bool IsCatapult { get => false; }
		public delegate void HealthChangedDelegate(string message);
		public event HealthChangedDelegate HealthChangedEvent;
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

        private double _health;

		public double Health
		{
			get { return _health; }
			set 
			{
				if (value > 0)
				{
					HealthChangedEvent?.Invoke($"{Name} Health was changed on {value - Health}hp and now it is: {value}");
					_health = value;
				}
				else
				{
					_health = 0;
					HealthChangedEvent?.Invoke($"{Name} is dead");
				}
			}
		}
		public void DamageUnit(Unit unit)
		{
			unit.Health -= DamagePoint;
		}
        private double _maxHealth;

        public double MaxHealth
		{
            get { return _maxHealth; }
            set { _maxHealth = value; }
        }
		private double _damagePoint;

		public double DamagePoint
		{
			get { return _damagePoint; }
			set { _damagePoint = value; }
		}
		public virtual void Info()
		{
			Console.WriteLine($" Unit {Name} has {Health}hp");
		}


	}
}
