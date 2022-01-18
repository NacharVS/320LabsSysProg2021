using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class Unit
    {

		public delegate void HealthChangedDelegate(string message);

		private double _health;
		public double Health
		{
			get { return _health; }
			set
			{
				if (value >= 0)
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

		public event HealthChangedDelegate HealthChangedEvent;
	}
}
