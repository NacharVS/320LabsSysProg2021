using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public interface IRangeUnit : IUnit
    {
        double Ammo { get; set; }
        double RangeDamage { get; }
        void RangeAttack(IUnit unit);
    }
}
