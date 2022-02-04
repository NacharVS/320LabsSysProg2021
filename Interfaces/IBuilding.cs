using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IBuilding :IUnit
    {
        public double Wall { get; }
    }
}
