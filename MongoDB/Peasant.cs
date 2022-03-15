using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDB
{
    public class Peasant : IPeasant
    {
        public double WalkingSpeed => 4;
        public double Health { get; set; }
        public double MaxHealth { get; set; }
        public string Name { get; set; }
        public ObjectId _id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
