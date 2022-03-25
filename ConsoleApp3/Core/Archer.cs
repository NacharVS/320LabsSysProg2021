using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3
{
    class Archer : UnitBattle, IRangeUnit
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
    }
}
