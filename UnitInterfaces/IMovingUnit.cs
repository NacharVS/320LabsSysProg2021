using System;
using System.Collections.Generic;
using System.Text;

namespace UnitInterfaces
{
    public interface IMovingUnit : IUnit
    {
        double WalkingSpeed { get; }
    }
}
