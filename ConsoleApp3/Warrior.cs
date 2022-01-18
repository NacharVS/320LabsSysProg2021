using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : Unit
    {
        Random rnd = new Random();
        public Warrior()
        {
            this.Health = 20;
            this.Damage = rnd.Next(1, 14);
        }
    }
}
