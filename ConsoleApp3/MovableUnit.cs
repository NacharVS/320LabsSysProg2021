using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class MovableUnit : Unit
    {
        public int unitSpeed;
        public MovableUnit(string name, double health, int unitSpeed) : base(name, health)
        {
        }
        public void Move()
        {
            Console.WriteLine($"Unit {Name} is moving with {unitSpeed} speed");
        }
    }
}
