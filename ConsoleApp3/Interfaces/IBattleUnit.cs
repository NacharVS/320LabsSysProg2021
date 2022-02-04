using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3.Interfaces
{
    internal interface IBattleUnit : IUnit
    {
        public double damage { get; set; }
        public bool CanRangeAttack { get; set; }
        public double MaxRangeAttack { get; set; }
        public double AttackSpeed { get; set; }

        public void AttackUnit(IUnit defender, double distance);

    }
}
