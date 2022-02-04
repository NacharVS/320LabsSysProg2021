using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IMovingUnit : IUnit
    {
        double WalkingSpeed { get; }
    }
}
