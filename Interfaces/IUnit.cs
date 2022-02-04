using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IUnit
    {
        string Name { get; set; }
        double Health { get; set; }
        double MaxHealth { get; set; }
        void Message();
    }
}
