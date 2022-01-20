using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class MovingUnit : Unit
    {
        private double _walkingSpeed;

        public double WalkingSpeed
        {
            get { return _walkingSpeed; }
            set { _walkingSpeed = value; }
        }
        public MovingUnit(string name, double health, double walkingSpeed) : base(name, health)
        {
            WalkingSpeed = walkingSpeed;
        }
        public void Move()
        {
            Console.WriteLine($"Unit {Name} is moving with {WalkingSpeed} speed");
        }
    }
}
