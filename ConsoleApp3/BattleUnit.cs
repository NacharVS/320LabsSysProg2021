using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class BattleUnit: Unit, IBattleUnit
    {
        public int minDamage;
        public int maxDamage;
        public BattleUnit(string name, double health,  int Attackspeed, int walkSpeed, int min, int max) : base(name, health, Attackspeed, walkSpeed)
        {
            minDamage = min;
            maxDamage = max;
        }
        public int MinDamage { get => minDamage; set => minDamage = value; }
        public int MaxDamage { get => maxDamage; set => maxDamage = value; }
    }
}
