using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class MovableUnit : Unit
    {
        private double _moveSpeed;
        public double MoveSpeed
        {
            get { return _moveSpeed; }
            set { _moveSpeed = value; }
        }
        public MovableUnit(string name, double health, double moveSpeed) : base(name, health)
        {
            MoveSpeed = moveSpeed;
        }

        public string Move()
        {
            return $"Name:{Name};Health:{Health};WalkingSpeed:{MoveSpeed}";
        }
    }
}
