using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class MovingUnits : Unit
    {
        public int speed;
        public MovingUnits(string name, double health, int speedParametr, double max) : base(name, health)
        {
            speed = speedParametr;
            MaxHealth = max;
        }
        public void Move()
        {
            Console.WriteLine($"Unit {Name} is moving with {speed} speed");
        }
    }
}
