using UnitInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Catapult : Unit,IBattleUnit
    {
        public double AttackSpeed { get; set; }
        public double Damage { get; set; }

        public bool IsCatapult => true;

        public double Health { get => health; set => health = value; }
        public double MaxHealth { get => maxHealth; set => maxHealth = value; }

        public string Name { get => name; set => name = value; }

        public Catapult(string name, double health, double maxHealth, double damage, double attackSpeed)
        {
            Health = health;
            MaxHealth = maxHealth;
            Damage = damage;
            AttackSpeed = attackSpeed;
            Name = name;
        }

        public double MeleeAttack()
        {
            throw new NotImplementedException();
        }

        public void Attack(IBattleUnit unit, double damage)
        {
            unit.Health -= damage;
        }

        public void Message()
        {
            Console.WriteLine($"{Name} health: {Health}, max health: {MaxHealth}");
        }
    }
}
