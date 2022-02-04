using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class Unit : IUnit
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

		string IUnit.name => name;
		

        double IUnit.Health { get => Health; set => Health = value; }

        public delegate void HealthChangerDelegate(string message);
		public event HealthChangerDelegate HealthChanerEvent;
	}
}
