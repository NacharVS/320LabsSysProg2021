using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Building : Unit
    {
        private double _wall;

        public Building(string name, int health, int armor) : base(name, health, armor)
        {
            Wall = health;
        }

        public double Wall { 
            get => _wall; 
            set => _wall = value > 0? value: 0; 
        }

        private void WallIsDestroyed()
        {
            Console.WriteLine("Wall is destroyed");
        }

        public override void Info()
        {
            Console.WriteLine($"{Name} Wall: {_wall} Health: {Health}");
        }
    }
}
