using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class UnmovableUnits
    {
		private double _health;

		public delegate void HealthChangedDelegate(string message);
		public event HealthChangedDelegate HealthChangedEvent;

		public double AttackSpeed;
		public double Health
		{
			get { return _health; }
			set
			{
				if (value > 0)
				{
					_health = value;
					HealthChangedEvent?.Invoke("Changed Hitpoints");
				}
				else
				{
					_health = 0;
					HealthChangedEvent?.Invoke("Unit is dead");
				}
			}
		}

		public virtual void Attack(Buildings building, double damage)
		{
			if (damage > 0)
			{
				building.Health -= damage;
			}
		}
	}
}
