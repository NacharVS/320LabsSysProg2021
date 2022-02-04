using System;
using System.Collections.Generic;
using System.Text;
using UnitInterfaces;

namespace Core
{
    public class Soldier : Unit,IBattleUnit, IMovingUnit
    {
        public double AttackSpeed { get; set; }
        public double WalkingSpeed => 10;
        public double Damage { get; set; }
        public double Health { get => health; set => health = value; }
        public double MaxHealth { get => maxHealth; set => maxHealth = value; }

        public bool IsCatapult => false;

        public string Name { get => name; set => name = value; }

        public Soldier(string name, double health, double maxHealth,double attackSpeed,double damage)
        {
            Name = name;
            Health = health;
            MaxHealth = maxHealth;
            AttackSpeed = attackSpeed;
            Damage = damage;
        }

        public double MeleeAttack()
        {
            if (Health > 0.4 * MaxHealth)
            {
                return MeleeAttack();
            }
            else
            {
                return MeleeAttack() * 2;
            }
        }

        public void Message()
        {
            Console.WriteLine($"{Name} health: {Health}, max health: {MaxHealth}");
        }

        public void Attack(IBattleUnit unit, double damage)
        {
            unit.Health -= damage;
        }
    }
}
