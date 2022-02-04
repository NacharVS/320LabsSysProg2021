using ConsoleApp3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Building : Unit, IBattleUnit
    {
        private double _wall;
        public double Wall { get => _wall; set => _wall = value < 0 ? 0 : value; }
        public string Name { get => name; set => name = value; }
        public double Health 
        { 
            get => health;
            set
            {
                if (Wall > 0)
                {
                    Wall -= (health - value);
                }
                else
                {
                    health = value < 0 ? 0 : value;
                }
            }
        }
        public double MaxHealth { get => maxHealth; set => maxHealth = value; }

        public Building(string name, double health, double maxHealth)
        {
            Name = name;
            Wall = health;
            MaxHealth = maxHealth;
        }


        public void Messange()
        {
            Console.WriteLine($"Building {Name} has {_wall} walls and {Health}hp");
        }
    }
}
