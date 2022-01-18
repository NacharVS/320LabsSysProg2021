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
				if (value > 0)
				{
					HealthChangedEvent?.Invoke($"Health has changed {value-_health}"); 
					_health = value;
					
				}
				else
				{
					_health = 0;
					HealthChangedEvent?.Invoke("Died");
				}
			}
		}

		public event HealthChangedDelegate HealthChangedEvent;
	}
}
