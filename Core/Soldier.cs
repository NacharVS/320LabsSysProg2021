using System;
using System.Collections.Generic;
using System.Text;
using UnitInterfaces;

namespace Core
{
    public class Soldier : Unit,IBattleUnit, IMovingUnit
    {
        public double AttackSpeed => 4;
        public double WalkingSpeed => 10;
        public double Damage => 18;
        public double Health { get => health; set => health = value; }
        public double MaxHealth { get => maxHealth; set => maxHealth = value; }

        public bool IsCatapult => false;

        public string Name { get => name; set => name = value; }

        public Soldier(string name, double health, double maxHealth)
        {
            Name = name;
            Health = health;
            MaxHealth = maxHealth;
        }

        public void MeleeAttack(IUnit unit)
        {
            if (Health > 0.4 * MaxHealth)
            {
                MeleeAttack(unit);
            }
        }

        public void Message()
        {
            Console.WriteLine($"{Name} health: {Health}, max health: {MaxHealth}");
        }

        public void Move()
        {
            Console.WriteLine($"Moving with walking speed {WalkingSpeed}");
        }

        public void Attack(IBattleUnit unit)
        {
            unit.Health -= Damage;
        }
    }
}
