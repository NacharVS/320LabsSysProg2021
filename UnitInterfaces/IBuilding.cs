using System;
using System.Collections.Generic;
using System.Text;

namespace UnitInterfaces
{
    public interface IBuilding :IUnit
    {
        public double Wall { get; }
    }
}
