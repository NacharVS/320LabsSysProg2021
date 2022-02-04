using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
	abstract class Tower
    {
		
		public delegate void HealthChangedDelegate(string mes);
		public event HealthChangedDelegate HealthChangedEvent;

		private double _health;

		public double Health
		{
			get { return _health; }
			set
			{
				
				if (value > 0)
				{
					_health = value;
					HealthChangedEvent?.Invoke($"Health: {value}, Changed to: {value - Health}");
				}
				else
				{
					_health = 0;
					HealthChangedEvent?.Invoke("Tower died");
				}
			}
		}
	}
}
