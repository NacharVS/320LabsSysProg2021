using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : Character
    {
        public Warrior()
        {
            MaxHealth = 100;
            Health = MaxHealth;
            Attack = 10;
        }
    }
}
