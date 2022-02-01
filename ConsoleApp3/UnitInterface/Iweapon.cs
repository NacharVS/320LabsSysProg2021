using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.UnitInterface
{
	interface Iweapon
	{
		int damage { get; }
		int WeaponHP { get; set; }
		void InflictDamage();
	}
}
