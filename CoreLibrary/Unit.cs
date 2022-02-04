﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace CoreLibrary
{
    public class Unit
    {
        public delegate void HealthChangedDelegate(string message);
        public event HealthChangedDelegate HealthChangedEvent; 
        public string Name { get; protected set; }
        public string UnitType { get; protected set; }
        public double MaxHealth { get; private set; }
        public double Health { get; private set; }
        public double MleeDamage { get; protected set; }
        public double MleeAttackDistance { get; protected set; } //in meters
        public int MleeAttackSpeed { get; protected set; } //in milliseconds
        public double WalkingSpeed { get; protected set; } //in meters per second

        public Unit() { }
        public Unit(string type, string name, double health)
        {
            UnitType = type;
            Name = name;
            MaxHealth = health;
            Health = MaxHealth;
        }

        public void Heal(double health)
        {
            Health += health;
            double healing = health;
            if (Health > MaxHealth)
            {
                healing -= Health - MaxHealth;
                Health = MaxHealth;
            }
            HealthChangedEvent?.Invoke($"{UnitType} {Name} получил лечение: {healing}\t" +
                                       $"Текущее HP: { Health}");
        }
        public void InflictDamage(double health)
        {
            Health -= health;
            double damage = health;
            if (Health < 0)
            {
                damage += Health;
                Health = 0;
            }
            HealthChangedEvent?.Invoke($"{UnitType} {Name} получил урон: {damage}\t" +
                                       $"Текущее HP: {Health}");
        }

        public void MleeAttack(Unit attackingCharacter, Unit attackedCharacter, double distance)
        {
            if (distance <= MleeAttackDistance && attackingCharacter.Health > 0 && attackedCharacter.Health > 0)
            {
                attackedCharacter.InflictDamage(attackingCharacter.MleeDamage);
            }
        }
    }
}
