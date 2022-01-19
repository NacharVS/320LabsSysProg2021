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
            this.Health = 500;
            this.MaxHealth = this.Health;
        }
        public void Heal(Unit pers)
        {
            pers.Health += HealAmount;
        }
    }
}
