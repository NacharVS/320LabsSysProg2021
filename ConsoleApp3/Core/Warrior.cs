using ConsoleApp3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : Unit, IBattleUnit, IMovementUnit
    {
        public Warrior(string name, double health, double maxHealth)
        {
            Name = name;
            Health = health;
            MaxHealth = maxHealth;
        }

        public double Damage = 12;
        public double WalkingSpeed => 3;
        public string Name { get => name; set => name = value; }
        public double Health { get => health; set => health = value < 0 ? 0 : value; }
        public double MaxHealth { get => maxHealth; set => maxHealth = value; }
        public double AttackSpeed => 4;
        public bool IsCatapult => false;

        public void Messange()
        {
            Console.WriteLine($"{Name} health {Health}");
        }

        public void MleeAttack(IBattleUnit unit)
        {
            unit.Health -= new Random().Next((int)(0.7 * Damage), (int)(1.3 * Damage) + 1);
        }

        public void Attack(IBattleUnit unit)
        {
            MeleeAttack(unit);
        }
    }
}

