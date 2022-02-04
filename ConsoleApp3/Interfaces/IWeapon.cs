using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Interfaces
{
    internal interface IWeapon
    {
        int damage { get; }
        int WeaponHP { get; set; }
        void InflictDamage();
    }
}
