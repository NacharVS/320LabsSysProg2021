using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Cleric : Unit
    {
        private double _heal;

        public double Heal { get => _heal; set => _heal = value; }

        internal Cleric()
        {
            Heal = 125;
        }

        public void ToHeal(double health)
        {
            health += Heal;
            GetEvent($"You're healed for {Heal} points");
        }
    }
}
