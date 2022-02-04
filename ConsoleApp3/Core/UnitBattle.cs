using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3
{
    class UnitBattle : Unit, IUnitBattle
    {
        public int minDamage;
        public int maxDamage;
        public UnitBattle(string name, double health, int attackSpeed, int walkingSpeed, int min, int max) : base(name, health, attackSpeed, walkingSpeed)
        {
            minDamage = min;
            maxDamage = max;
        }
        public int MinDamage { get => minDamage; set => minDamage = value; }
        public int MaxDamage { get => maxDamage; set => maxDamage = value; }
    }
}
