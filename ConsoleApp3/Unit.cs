using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class Unit
    {
		private double _health;
		public virtual double MaxHealth { get; set; }
		private double _damage;
		public delegate void HealthChangedDelegate(double health, double valueChanged);

		
		public double Health
		{
			get { return _health; }
			set
			{
				if (value >= 0)
				{
					HealthChandgedEvent?.Invoke(value, value - _health);
					_health = value;
					
				}
				else
				{
					_health = 0;
					HealthChandgedEvent?.Invoke(_health, value);
				}
			}
		}

		public void damageUnit(double damage)
        {
			_health -= damage;
			if (_health > 0)
			{
				_health = 0;
			}
		}

		public double Damage
        {
			get { return _damage; }
			set{_damage = value;}
		}

		public event HealthChangedDelegate HealthChandgedEvent;


	}
}
