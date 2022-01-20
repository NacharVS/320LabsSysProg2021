using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Peasant : MovingUnits
    {
        public Peasant(string name, double health, int Speed, double max):  base(name, health, Speed, max)
        {
            Name = name;
            Health = health;
            speed = Speed;
            MaxHealth = max;
        }
    }
}
