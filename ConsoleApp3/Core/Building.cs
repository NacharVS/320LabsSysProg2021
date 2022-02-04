using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3
{
    class Building : Unit, IBuilding
    {
        private double _wall;
        public Building(string name, double health, int attackSpeed, int walkingSpeed) : base(name, health, attackSpeed, walkingSpeed)
        {
            Wall = health;
        }
        public double Wall { get => _wall; set => _wall = value; }
        public override void Message()
        {
            Console.WriteLine($"Building {Name} has {_wall} walls and {Health}hp");
        }
    }
}
