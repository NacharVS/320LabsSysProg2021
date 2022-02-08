using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Javelin : IRepairible, IThrowableWeapon
    {
        public int damage => 6;
        public int durability;

        public void InflictDamage()
        {
            Console.WriteLine($"tik {damage}");
        }

        public void Repair()
        {
            Console.WriteLine($"{GetType().Name} has repaired");
        }

        public void Throw()
        {
            Console.WriteLine($"{GetType().Name} fooooooh");
        }
    }
}
