using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : Unit, IBattleUnit, IMovingUnit
    {
        public Warrior(string newName, double newHp)
        {
            Name = newName;
            MaxHealth = newHp;
            Health = MaxHealth;
        }

        public double Damage => 15;
        public double AttackSpeed => 3;
        public string Name { get => _name; set => _name = value; }
        public double Health { get => _health; set => _health = value < 0 ? 0 : value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        public double WalkingSpeed => 4;

        public void Attack(IUnit unit)
        {
            MeleeAttack(unit);
        }

        public void MeleeAttack(IUnit unit)
        {
            unit.Health -= new Random().Next((int)(0.7 * Damage), (int)(1.3 * Damage) + 1);
        }

        public void Move()
        {
            Console.WriteLine($"{Name} speed {WalkingSpeed}");
        }
    }
}
