using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class Unit
    {
		
		public delegate void HealthChangedDelegate(string mes);
		public event HealthChangedDelegate HealtChangedEvent;

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
