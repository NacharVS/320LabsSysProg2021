using System;
using System.Collections.Generic;
using System.Text;
using Coree.Interface;

namespace Coree.Units
{
    public class Building : Unit, IBuilding
    {
        public Building(string newName)
        {
            Name = newName;
            MaxHealth = 500;
            Health = MaxHealth;
            Wall = Health;
        }

        private double _wall;
        public double Wall { get => _wall; set => _wall = value < 0 ? 0 : value; }
        public string Name { get => _name; set => _name = value; }
        public double Health
        {
            get => _health;
            set
            {
                if (Wall > 0)
                {
                    Wall -= (_health - value);
                }
                else
                {
                    _health = value < 0 ? 0 : value;
                }
            }
        }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }

        public override string ToString()
        {
            return base.ToString() + $"Wall:{Wall};";
        }
    }
}
