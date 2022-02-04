using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Interfaces
{
    interface IMovementUnit : IBattleUnit
    {
        double WalkingSpeed { get; }
    }
}
