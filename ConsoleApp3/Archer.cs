using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Archer : Character
    {
        public Archer()
        {
            MaxHealth = 100;
            Health = MaxHealth;
            Attack = 5;
        }
    }
}
