using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Building:Unit, IBuilding
    {
        private double _wall;
        public Building(string name, double health) : base(name, health,0,0)
        {
            Wall = health;
        }
        public double Wall { get => _wall; set => _wall = value; }
        public override void Info()
        {
            Console.WriteLine($"Building {Name} has {_wall} walls and {Health}hp");
        }
    }
}
