using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Models
{
    internal class Peasant : Character
    {
        internal Peasant()
        {
            MaxHealth = 1500;
            Health = 1000;
            WalkSpeed = 50;
            AttackRange = 1;
            Damage = 1;
        }
    }
}
