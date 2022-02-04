using UnitInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Peasant : IMovingUnit
    {
        public double WalkingSpeed => 4;
        public double Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double MaxHealth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Peasant(string name,double health,double maxHealth)/*: base(name,90,2)*/
        {
            Name = name;
            Health = health;
            MaxHealth = maxHealth;
        }

        public void Message()
        {
            Console.WriteLine($"{Name} helth: {Health}, max health: {MaxHealth}");
        }
    }
}
