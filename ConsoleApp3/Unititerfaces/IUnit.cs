using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Unititerfaces
{
    public interface IUnit
    {
        double Health { get; set; }
        double MaxHealth { get; set; }
        void Message();
    }
}
