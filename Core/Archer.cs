using UnitInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Archer : IBattleUnit
    {
        private int Arrows { get; set; }
        public double AttackSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Damage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double MaxHealth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsCatapult => false;

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Archer(string name, double health, double maxHealth,double damage,double attackSpeed)
        {
            Arrows = 5;
            Health = health;
            MaxHealth = maxHealth;
            Damage = damage;
            AttackSpeed = attackSpeed;
            Name = name;
        }

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
            throw new NotImplementedException();
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
