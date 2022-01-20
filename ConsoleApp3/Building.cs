using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Building:Unit
    {
        private double _wall;
        public Building(string name, double health) : base(name, health)
        {
            Name = name;
            Health = health;
            Wall = health;
        }
        public double Wall { get => _wall; set => _wall = value; }
        private void WallIsDestroyed()
        {
            Console.WriteLine("One wall was destroyed");
        }
        public override void Info()
        {
            Console.WriteLine($"Building {Name} has {_wall} walls and {Health}hp");
        }
    }
}
