using System;
using System.Collections.Generic;
using System.Text;

namespace Coree.Interface
{
    class IMovableUnit : IUnit
    {
        double WalkingSpeed { get; }

        void Move();
    }
}
