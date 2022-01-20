using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class MovingUnits : Unit
    {
        private double walkingSpeed;

        public double WalkingSpeed
        {
            get { return walkingSpeed; }
            set { walkingSpeed = value; }
        }
        public MovingUnits(string name, double health, double walkingSpeed) : base(name,health)
        {
            WalkingSpeed = walkingSpeed;
        }
    }
}
