using UnitInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Archer : Unit,IBattleUnit, IMovingUnit
    {
        public Archer(string name,double health,double maxHealth)
        {
            Arrows = 5;
            Health = health;
            MaxHealth = maxHealth;
            Name = name;
        }

        private int Arrows { get; set; }
        public double AttackSpeed { get; set; }
        public double Damage => 6;
        public double Health { get => health; set => health = value; }
        public double MaxHealth { get => maxHealth; set => maxHealth = value; }
        public bool IsCatapult => false;

        public string Name { get => name; set => name = value; }

        public double WalkingSpeed => throw new NotImplementedException();

        public void RangeAttack(IUnit unit)
        {
            if (Arrows > 0)
            {
                double presentDamage = (new Random()).Next(10,80);
                unit.Health -= presentDamage;
                Arrows--;
            }
            else
            {
                MeleeAttack(unit);
            }
        }

        public void MeleeAttack(IUnit unit)
        {
            double presentDamage = (new Random()).Next(10, 80);
            unit.Health -= presentDamage;
        }

        public void Message()
        {
            Console.WriteLine($"{Name} health: {Health}, max health: {MaxHealth}, damage: {Damage}, attack speed: {AttackSpeed}");
        }

        public void Attack(IBattleUnit unit)
        {
            RangeAttack(unit);
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
