using System;
using System.Collections.Generic;
using System.Text;

namespace Coree.Unit
{
    public class Unit
    {
		internal string _name;
		internal double _health;
		internal double _maxHealth;

		public override string ToString()
		{
			return $"Name:{_name};Health:{_health};";
		}
	}
}
