using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IMovingUnit
    {
        double Health { get; set; }
        double MaxHealth { get; set; }
        double WalkingSpeed { get; set; }
    }
}
