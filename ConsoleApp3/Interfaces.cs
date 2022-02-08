using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{

    interface IWeapon
    {
        int damage { get; }
        void InflictDamage();
    }
    interface IRepairible
    {
        void Repair();
    }
    interface IThrowableWeapon : IWeapon
    {
        void Throw();
    }

    class Interfaces
    {
    }
}
