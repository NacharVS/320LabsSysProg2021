using System;
using System.Collections.Generic;
using System.Text;

namespace UnitsInterfaces
{
    public interface IBuilding : IUnit
    {
        double Wall { get; set; }
    }
}
