using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3.Models
{
    internal class Building : Unit, IBuilding
    {
        private double _wall;

        public double Wall { get => _wall; set => _wall = value; }

        internal Building()
        {
            Wall = 1500;
            Health = 1000;
            MaxHealth = Health;
        }
    }
}
