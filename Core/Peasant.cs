using UnitInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Peasant : Unit,IMovingUnit
    {
        public double WalkingSpeed => 4;
        public double Health { get => health; set => health=value; }
        public double MaxHealth { get => maxHealth; set => maxHealth=value; }
        public string Name { get => name; set => name = value; }

        public Peasant(string name,double health,double maxHealth)
        {
            Name = name;
            Health = health;
            MaxHealth = maxHealth;
        }

        public void Message()
        {
            Console.WriteLine($"{Name} helth: {Health}, max health: {MaxHealth}");
        }

        public void Move()
        {
            Console.WriteLine($"Moving with walking speed {WalkingSpeed}");
        }
    }
}
