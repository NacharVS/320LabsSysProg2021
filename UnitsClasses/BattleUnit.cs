using System;
using System.Collections.Generic;
using System.Text;
using UnitsInterfaces;

namespace UnitsClasses
{
    public abstract class BattleUnit : Unit, IBattleUnit
    {
        public int _minDamage;
        public int _maxDamage;

        public BattleUnit(string name, int health, int attackSpeed, int walkingSpeed, int min, int max) : base(name, health, attackSpeed, walkingSpeed)
        {
            _minDamage = min;
            _maxDamage = max;
        }
        public int MinDamage { get => _minDamage; set => _minDamage = value; }
        public int MaxDamage { get => _maxDamage; set => _maxDamage = value; }
    }
}
