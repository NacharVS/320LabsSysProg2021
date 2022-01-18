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

		public double Health
		{
			get { return _health; }
			set { if (value > 0)
					{
						_health = value;
						HealthChangedEvent?.Invoke($"{_health}");
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
			unit.Damage -= Damage;
		}

	}
}
