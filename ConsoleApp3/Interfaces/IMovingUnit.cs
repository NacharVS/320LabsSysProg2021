using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public interface IMovingUnit : IUnit
    {
        double WalkingSpeed { get; }

        void Move();
    }
}
