using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Building : Unit
    {
        private double wall;
        public double Wall { get { return wall; } set { wall = value; } }

        public Building(string name, double health,double damage) : base(name,health,damage)
        {
            Wall = health;
        }

        public override void Message()
        {
            Console.WriteLine($"Wall: {Wall}");
        }
    }
}
