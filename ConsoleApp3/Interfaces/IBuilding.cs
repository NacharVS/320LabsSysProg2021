using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public interface IBuilding : IUnit
    {
        public double Wall { get; }
    }
}
