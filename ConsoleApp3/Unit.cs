using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class Unit
    {
		public delegate void HealthChangedDelegate(string message);
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
					HealthChangedEvent?.Invoke("Unit was damaged");
				}
				else
				{
					_health = 0;
					HealthChangedEvent?.Invoke("Unit is dead");
				}
			}
		}


	}
}
