using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
	public class Building : Unit
	{
		private double _wall;

		public double Wall
		{
			get { return _wall; }
			set
			{
				if (value < 0)
				{
					_wall = 0;
				}
				else
				{
					_wall = value;
				}
			}
		}

		public Building(string name, double health) : base(name, health)
		{
			Wall = health;
		}

		public string WallDestroyed()
		{
			return "Wall is destroyed";
		}
		public override string ToString()
		{
			return base.ToString() + $";Wall:{_wall}";
		}
	}
}
