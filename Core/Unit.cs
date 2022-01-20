using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public abstract class Unit
    {
		public Unit(string name, double health)
		{
			Name = name;
			Health = health;
			_maxHealth = health;
		}

		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}


		public delegate void HealthChangedDelegate(string message);

		private double _health;
		public double _maxHealth;
		public double Health
		{
			get { return _health; }
			set
			{
				var previousHealth = Health;
				if (value > 0)
				{
					_health = value;
					HealthChangedEvent?.Invoke($"Health: {value}, Changed to: {Health - previousHealth}");
				}
				else if (value > _maxHealth)
				{
					_health = _maxHealth;
					HealthChangedEvent?.Invoke($"Health: {value}, Changed to: {Health - previousHealth}");
				}
				else
				{
					_health = 0;
					HealthChangedEvent?.Invoke("Unit died");
				}
			}
		}

		public event HealthChangedDelegate HealthChangedEvent;

		public override string ToString()
		{
			return $"Name:{Name};Health:{Health}";
		}
	}
}
