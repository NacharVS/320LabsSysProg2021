using UnitInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Building : Unit, IUnit
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

        public double Health { get => health; set => health = value; }
        public double MaxHealth { get => maxHealth; set => maxHealth = value; }
        public string Name { get => name; set => name = value; }

        public Building(string name, double health)
        {
            Name = name;
            Wall = health;
        }

        public void Message()
        {
            Console.WriteLine($"Wall: {Wall}, health: {Health}");
        }
    }
}
