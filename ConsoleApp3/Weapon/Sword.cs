using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Sword : Interfaces.IDamage
    {
        public int damage => 5;

        public void InflictDamage(Unit unit)
        {
            unit._health -= damage;
        }
    }
}
