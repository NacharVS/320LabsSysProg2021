using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Weapon
{
    class Bow : Interfaces.IDamage
    {
        public int damage => 7;

        public void InflictDamage(Unit unit)
        {
            unit._health -= damage;
        }
    }
}
