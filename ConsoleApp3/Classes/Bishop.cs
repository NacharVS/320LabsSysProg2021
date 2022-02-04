using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Bishop : Unit
    {
        private double _heal;
        public double HealAmount { get; set; }

        public Bishop()
        {
            Hp = 50;
        }
        public Bishop(double health)
        {
            Hp = health;
            _heal = 20;
        }
        public double Heal(Unit unit)
        {
            unit.Hp += _heal;
            return HealAmount;
        }
    }
}
