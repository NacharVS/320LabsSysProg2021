using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3.Models
{
    internal class Warrior : Character
    {
        public override double Health
        {
            get => base.Health;
            set 
            { 
                base.Health = value;
                GetDamageEvent?.Invoke($"The Warrior has {base.Health} health points");
            }
        }
        internal Warrior()
        {
            MaxHealth = 1000;
            Health = 1000;
            Damage = 57;
            WalkSpeed = 100;
            AttackRange = 1;
        }

        internal override event GetDamageDelegate GetDamageEvent;
    }
}
