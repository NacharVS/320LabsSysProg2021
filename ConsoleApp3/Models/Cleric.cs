using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Models
{
    internal class Cleric : Unit
    {
        private double _heal;

        public double Heal
        {
            get => _heal; 
            set
            {
                _heal = value;
            }
        }

        internal Cleric()
        {
            Heal = 125;

        }

        public void ToHeal(Character character)
        {
            character.Health += Heal;
            GetDamageEvent?.Invoke($"The {character.GetType()} has been healed for {Heal} points");
        }

        internal override event GetDamageDelegate GetDamageEvent;
    }
}
