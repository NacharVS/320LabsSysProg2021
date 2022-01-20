using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Building : Unit
    {
        private double wall;
        public double Wall
        {
            get
            { 
                return wall; 
            }
            set
            {
                if (value < 0)
                    wall = 0;
                else
                    wall = value;
            }
        }

        public Building(string name, double health) : base(name,health)
        {
            Wall = health;
        }

        public override void Message()
        {
            Console.WriteLine($"Wall: {Wall}, health: {Health}");
        }
    }
}
