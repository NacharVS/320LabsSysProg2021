using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : BattleUnit
    {
        public Warrior(string name, double health, double attackPoint, double maxHealth, int min, int max) : base(name, health,  10, maxHealth, min, max )
        {
            Name = name;
            Health = health;
            DamagePoint = attackPoint;
            minDamage = min;
            maxDamage = max;
            MaxHealth = maxHealth;

        }
        private double _damage;

        public double Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
    }
}
