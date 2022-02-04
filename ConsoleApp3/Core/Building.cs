using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Building : Unit
    {
        private double _wall;
        public double Wall { get => _wall; set => _wall = value; }
        public Building(string name, double health) : base(name, health)
        {
            Wall = health;
        }
        public override void Info()
        {
            Console.WriteLine($"Building {Name} has {_wall} walls and {Health}hp");
        }
    }
}
