using System;
using System.Collections.Generic;
using System.Text;
using UnitsInterfaces;

namespace UnitsClasses
{
    public class Building : Unit, IBuilding
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

        public override string ToString()
        {
            return $"{Name} Wall: {_wall} Health: {Health}";
        }
    }
}
