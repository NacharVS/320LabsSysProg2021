using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class Unit
    {
		public delegate void HealthChangedDelegate(string message);

		public Unit(double health)
        {
			Health = health;
        }

		private double _health;
		public double Health
		{
			get { return _health; }
			set
			{
				if (value >= 0)
				{
					_health = value;
					HealthChangedEvent?.Invoke($"Health has changed{value - _health}");
				}
				else
				{
					_health = 0;
					HealthChangedEvent?.Invoke("Unit died");
				}
			}
		}

		public event HealthChangedDelegate HealthChangedEvent;

		public double Attack(Unit unit, double damage)
		{
			if (damage >= 0)
				unit.Health -= damage;
			return 0;
		}
	}
}
