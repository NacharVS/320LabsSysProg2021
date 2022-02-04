using ConsoleApp3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Archer : Unit, IBattleUnit, IMovementUnit
    {
        int Arrows;
        public Archer(string name, double health, double maxHealth) 
        {
            Name = name;
            Arrows = 5;
            Health = health;
            MaxHealth = maxHealth;
        }

        public double Damage => 5;
        public double AttackSpeed => 6;
        public string Name { get => name; set => name = value; }
        public double Health { get => health; set => health = value < 0 ? 0 : value; }
        public double MaxHealth { get => maxHealth; set => maxHealth = value; }
        public double WalkingSpeed => 3;
        public bool IsCatapult => false;

        public void Attack(IUnit unit)
        {
            RangeAttack(unit);
        }

        public void Messange()
        {
            Console.WriteLine($"{Name} health: {Health}, max health: {MaxHealth}, damage: {Damage}, attack speed: {AttackSpeed}");
        }

        public void MleeAttack(IUnit unit)
        {
             unit.Health -= 4;
        }

        public void RangeAttack(IUnit unit)
        {
            if (Arrows > 0)
            {
                unit.Health -= (new Random()).Next(5, 20);
                Arrows--;
            }
            else
            {
                MleeAttack(unit);
            }
        }
    }
}
