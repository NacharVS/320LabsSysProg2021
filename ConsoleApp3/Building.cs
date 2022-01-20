using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Building : Unit
    {
        private double _wall;

        public Building(string name, int health) : base(name, health, 0, 0)
        {
            Wall = health;
        }

        public double Wall { 
            get => _wall; 
            set => _wall = value > 0? value: 0; 
        }

        public override void Info()
        {
            Console.WriteLine($"{Name} Wall: {_wall} Health: {Health}");
        }
    }
}
