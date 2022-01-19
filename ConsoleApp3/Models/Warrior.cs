using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Models
{
    internal class Warrior : Unit
    {
        private double _damage;
        public double Damage { get => _damage; set => _damage = value; }

        internal Warrior()
        {
            Health = 1000;
            Damage = 57;
        }
    }
}
