using System;
using System.Collections.Generic;
using System.Text;
using UnitsInterfaces;

namespace UnitsClasses
{
    public class Warrior : BattleUnit, IBattleUnit
    {
        private bool _rage = false;

        public Warrior(string name, int health, int attackSpeed, int walkingSpeed, int minDamage, int maxDamage) : base(name, health, attackSpeed, walkingSpeed, minDamage, maxDamage)
        {
        }
        public int MinDamage { get => base.MinDamage; set => base.MinDamage = value; }
        public int MaxDamage { get => base.MaxDamage; set => base.MaxDamage = value; }
    }
}