using System;
using System.Collections.Generic;
using System.Text;

namespace UnitsInterfaces
{
    public interface IUnit
    {
        double Health { get; set; }
        double AttackSpeed { get; set; }
        double WalkingSpeed { get; set; }
        string ToString();
    }
}
