using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Interfaces
{
    public interface IUnit
    {
        string Name { get; set; }
        double Health { get; set; }
        double MaxHealth { get; set; }
        void Messange();
    }
}
