using ConsoleApp3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Catapult : Unit, IBattleUnit
    {
        public bool IsCatapult => true;

        public string Name { get => name; set => name = value; }
        public double Health { get => health; set => health = value < 0 ? 0 : value; }
        public double MaxHealth { get => maxHealth; set => maxHealth = value; }

        public double Damage => 5;

        public double AttackSpeed => 13;

        public Catapult(string name, double health, double attackPoint)
        {
            Name = name;
            Health = health;
            MaxHealth = maxHealth;
        }

        public void Messange()
        {
            Console.WriteLine($"Catapult {Name} has {Health}hp");
        }

        public void MleeAttack(IBattleUnit unit)
        {
            throw new NotImplementedException();
        }

        public void Attack(IBattleUnit unit)
        {
            unit.Health -= Damage;
        }
    }
}
