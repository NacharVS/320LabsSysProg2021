using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Interfaces
{
    interface IUnit
    {
        double Health { get; set; }
        double AttackSpeed { get; set; }
        double WalkingSpeed { get; set; }
    }
}
