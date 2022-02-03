using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Building : IUnit
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

        public double Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double MaxHealth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Building(string name, double health)
        {
            Wall = health;
        }

        public void Message()
        {
            Console.WriteLine($"Wall: {Wall}, health: {Health}");
        }
    }
}
