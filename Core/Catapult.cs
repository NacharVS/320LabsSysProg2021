using UnitInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Catapult : Unit,IBattleUnit
    {
        public double AttackSpeed => 15;
        public double Damage => 3;

        public bool IsCatapult => true;

        public double Health { get => health; set => health = value; }
        public double MaxHealth { get => maxHealth; set => maxHealth = value; }

        public string Name { get => name; set => name = value; }

        public Catapult(string name, double health, double maxHealth)
        {
            Health = health;
            MaxHealth = maxHealth;
            Name = name;
        }

        public void MeleeAttack(IUnit unit)
        {
            throw new NotImplementedException();
        }

        public void Attack(IBattleUnit unit)
        {
            unit.Health -= Damage;
        }

        public void Message()
        {
            Console.WriteLine($"{Name} health: {Health}, max health: {MaxHealth}");
        }
    }
}
