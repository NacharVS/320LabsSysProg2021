using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Building : Unit
    {
        private double wall;
        public double Wall { get { return wall; } set { wall = value; } }

        public Building(string name, double health) : base(name,health)
        {
            Wall = health;
        }

        public override void Message()
        {
            Console.WriteLine($"Wall: {Wall}");
        }
    }
}
