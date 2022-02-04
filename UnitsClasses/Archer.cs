using System;
using System.Collections.Generic;
using System.Text;
using UnitsInterfaces;

namespace UnitsClasses
{
    public class Archer : BattleUnit, IRangeUnit
    {
        private int _arrows;
        private int _minRangeDamage;
        private int _maxRangeDamage;

        public Archer(string name, int health, int attackSpeed, int walkingSpeed) : base(name, health, attackSpeed, walkingSpeed, 1, 2)
        {
            _arrows = 5;
            _minRangeDamage = 4;
            _maxRangeDamage = 12;
        }

        public int MinRangeDamage { get => _minRangeDamage; set => _minRangeDamage = value; }
        public int MaxRangeDamage { get => _maxRangeDamage; set => _maxRangeDamage = value; }
        public int Ammo { get => _arrows; set => _arrows = value; }
        public int MinDamage { get => base.MinDamage; set => base.MinDamage = value; }
        public int MaxDamage { get => base.MaxDamage; set => base.MaxDamage = value; }

        public override string ToString()
        {
            return $"{Name} Health: {Health} Arrows: {_arrows}";
        }
    }
}
