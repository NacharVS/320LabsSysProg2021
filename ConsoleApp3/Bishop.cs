using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Bishop : Unit
    {
        private double _healAmount;
        public double HealAmount
        {
            get { return _healAmount; }
            set { _healAmount = value;}
        }

        public Bishop()
        {
            Health = 100;
            Damage = 5;
            HealAmount = 10;
        }

        public Bishop(double hp, double ha)
        {
            Health = hp;
            HealAmount = ha;
        }
    }
}
