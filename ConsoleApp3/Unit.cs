using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class Unit
    {
		private double _health;

		public delegate void HealthChangedDelegate(string message);
		public event HealthChangedDelegate HealthChangedEvent;

		//public double AttackSpeed;
		//public double WalkingSpeed;
		public string Name;
		public double Health
		{
			get { return _health; }
			set 
			{
				if (value > 0)
				{
					_health = value;
					HealthChangedEvent?.Invoke($"Unit {this.Name} – Changed Hitpoints. Total: {this._health}");
				}
				else
				{
					_health = 0;
					HealthChangedEvent?.Invoke($"Unit {this.Name} is dead");
				}
			}
		}
	}
}
