using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Interfaces
{
    interface IThrowableWeapon : Interfaces.IDamage
    {
        int throwDamage { get; }
        public void Throw(Unit unit);
    }
}
