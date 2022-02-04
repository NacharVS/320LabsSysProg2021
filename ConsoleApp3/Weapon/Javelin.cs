using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Weapon
{
    class Javelin : Interfaces.IThrowableWeapon
    {
        public int damage => 6;
        public int throwDamage => 4;

        public void InflictDamage(Unit unit)
        {
            unit._health -= damage;
        }

        public void Throw(Unit unit)
        {
            unit._health -= throwDamage;
        }
    }
}
