using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class Unit
    {
		public string name;
		private double _health;

		public double Health
		{
			get { return _health; }
			set {
				HealthChanerEvent?.Invoke($"Здоровье {name} было изменено на: " + (value - _health) + "\n" + "Значение здоровья теперь: " + value);
				_health = value; 
				}
		}

		public delegate void HealthChangerDelegate(string message);
		public event HealthChangerDelegate HealthChanerEvent;
	}
}
