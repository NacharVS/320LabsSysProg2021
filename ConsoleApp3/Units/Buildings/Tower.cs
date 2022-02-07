using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
	public class Tower : Unit, IBuilding
	{
		public Tower(string newName, double newheath)
		{
			Name = newName;
			MaxHealth = newheath;
			Health = MaxHealth;
			Wall = Health;
		}

		private double _wall;
		public double Wall { get => _wall; set => _wall = value < 0 ? 0 : value; }
		public string Name { get => _name; set => _name = value; }

		public double Health
		{
			get => _health;
			set
			{
				if (Wall > 0)
				{
					Wall -= (_health - value);
				}
				else
				{
					_health = value < 0 ? 0 : value;
				}
			}
		}
		public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }
	}
}
