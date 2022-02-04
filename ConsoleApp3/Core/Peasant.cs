using ConsoleApp3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Peasant : Unit,IMovementUnit
    {
        public Peasant(string name, double health, double maxHealth)
        {
            Name = name;
            Health = health;
            MaxHealth = maxHealth;
        }

        public double WalkingSpeed => 5;

        public string Name { get => name; set => name = value; }
        public double Health { get => health; set => health = value < 0 ? 0 : value; }
        public double MaxHealth { get => maxHealth; set => maxHealth = value; }

        public void Messange()
        {
            Console.WriteLine($"{Name} helth: {Health}");
        }
    }
}
