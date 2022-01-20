﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class MovableUnit : Unit
    {
		private double _walkingSpeed;

		public double WalkingSpeed
		{
			get { return _walkingSpeed; }
			set { _walkingSpeed = value; }
		}

		public MovableUnit(string name, double health, double walkingSpeed) : base(name, health)
		{
			WalkingSpeed = walkingSpeed;
		}

		public string Move()
		{
			return $"Name:{Name};Health:{Health};WalkingSpeed:{WalkingSpeed}";
		}
    }
}
