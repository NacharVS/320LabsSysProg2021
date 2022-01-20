using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Buildings
    {
		private double _health;

		public delegate void HealthChangedDelegate(string message);
		public event HealthChangedDelegate HealthChangedEvent;
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

        public Buildings(double health)
        {
            Health = health;
        }
    }
}
