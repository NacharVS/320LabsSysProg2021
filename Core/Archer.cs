using UnitInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Archer : Unit,IBattleUnit
    {
        public Archer(string name, double health, double maxHealth,double damage,double attackSpeed)
        {
            Arrows = 5;
            Health = health;
            MaxHealth = maxHealth;
            Damage = damage;
            AttackSpeed = attackSpeed;
            Name = name;
        }

        private int Arrows { get; set; }
        public double AttackSpeed { get; set; }
        public double Damage { get; set; }
        public double Health { get => health; set => health = value; }
        public double MaxHealth { get => maxHealth; set => maxHealth = value; }
        public bool IsCatapult => false;

        public string Name { get => name; set => name = value; }

        public double RangeAttack()
        {
            if (Arrows > 0)
            {
                double presentDamage = (new Random()).Next(10,80);
                Arrows--;
                return presentDamage;
            }
            else
            {
                return MeleeAttack();
            }
        }

        public double MeleeAttack()
        {
            return 2;
        }

        public void Message()
        {
            Console.WriteLine($"{Name} health: {Health}, max health: {MaxHealth}, damage: {Damage}, attack speed: {AttackSpeed}");
        }

        public void Attack(IBattleUnit unit, double damage)
        {
            unit.Health -= damage;
        }
    }
}
