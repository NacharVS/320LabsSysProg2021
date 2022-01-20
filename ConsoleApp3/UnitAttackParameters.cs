using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class UnitAttackParameters
    {
        public Unit AttackingUnit;
        public Unit AttackedUnit;
        public double Distance;

        public UnitAttackParameters(Unit attackingUnit, Unit attackedUnit, double distance)
        {
            AttackingUnit = attackingUnit;
            AttackedUnit = attackedUnit;
            Distance = distance;
        }
    }
}
