using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Interfaces
{
    interface IDamage
    {
        int damage { get; }
        public void InflictDamage(Unit unit);
    }
}
