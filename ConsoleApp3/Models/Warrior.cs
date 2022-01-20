using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3.Models
{
    internal class Warrior : Character
    {
        internal Warrior()
        {
            MaxHealth = 1000;
            Health = 1000;
            Damage = 57;
            WalkSpeed = 100;
            AttackRange = 1;
        }
    }
}
