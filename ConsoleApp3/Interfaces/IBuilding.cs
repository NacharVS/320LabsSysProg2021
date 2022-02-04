using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Interfaces
{
    interface IBuilding : IUnit
    {
        double Wall { get; set; }
    }
}
