using System;
using System.Collections.Generic;
using System.Text;

namespace Coree.Interface
{
    class IRangedUnit : IUnit
    {
        double Ammo { get; set; }
        double RangeDamage { get; }
        void RangeAttack(IUnit unit);
    }
}
