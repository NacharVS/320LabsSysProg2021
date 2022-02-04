using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
	class Unit
	{

		public delegate void HealthChangedDelegate(string message);

		public double _health;
		public Interfaces.IDamage weapon { get; set; }

		public Unit(Interfaces.IDamage weapon, double hp)
        {
			this.weapon = weapon;
			_health = hp;
		}

		public void Throw(Interfaces.IThrowableWeapon weapon, Unit unit)
		{
			weapon.Throw(unit);
		}











		//public double Health
		//{
		//	get { return _health; }
		//	set
		//	{
		//		if (value > 0)
		//		{
		//			HealthChangedEvent?.Invoke($"Health has changed {value-_health}"); 
		//			_health = value;

		//		}
		//		else
		//		{
		//			_health = 0;
		//			HealthChangedEvent?.Invoke("Died");
		//		}
		//	}
		//}

		public event HealthChangedDelegate HealthChangedEvent;
	}
}
