using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Peasant : Unit
    {
        Random rnd = new Random();
        public Peasant()
        {
            this.Health = 10;
            this.Damage = rnd.Next(1, 3);
        }
    }
}
