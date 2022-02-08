using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Bow:IWeapon
    {
        public int damage => 7;

        public void InflictDamage()
        {
            Console.WriteLine($"piuuuuuu {damage}");
        }
    }
}
