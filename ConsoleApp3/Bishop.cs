using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Bishop : Unit
    {
        public double HealAmount { get; set; }

        public Bishop()
        {
            HealAmount = 100;
        }
        public void Heal(Unit pers)
        {
            pers.Health += HealAmount;
        }
    }
}
