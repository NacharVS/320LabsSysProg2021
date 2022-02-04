using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    interface IHealUnit
    {
        public double Healmount { get; }
        public void DoHeal(IUnit unit);
    }
}
