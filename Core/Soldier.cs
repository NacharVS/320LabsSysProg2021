using System;
using System.Collections.Generic;
using System.Text;
using UnitInterfaces;

namespace Core
{
    public class Soldier : IBattleUnit, IMovingUnit
    {
        public double AttackSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double WalkingSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Damage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double MaxHealth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsCatapult => false;

        public string name;
        public string Name { get => name; set => name = value; }

        public Soldier(string name, double health, double maxHealth)/* : base(name,100,10,5,2)*/
        {
            Name = name;
            Health = health;
            MaxHealth = maxHealth;
        }

        public double MeleeAttack()
        {
            if (Health > 0.4 * MaxHealth)
            {
                //return base.MeleeAttack();
                throw new NotImplementedException();
            }
            else
            {
                //return base.MeleeAttack() * 2;
                throw new NotImplementedException();
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
