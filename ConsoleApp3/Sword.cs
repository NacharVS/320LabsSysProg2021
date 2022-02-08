using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Sword:IWeapon, IRepairible
    {
        public int damage => 5;

        public void InflictDamage()
        {
            Console.WriteLine($"shooooh! {damage}");
        }

        public void Repair()
        {
            Console.WriteLine($"{GetType().Name} has repaired");
        }
    }
}
