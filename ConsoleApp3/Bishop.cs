using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Bishop
    {
        public double HealAmount { get; set; }

        public double Heal()
        {
            return HealAmount;
        }

        public Bishop()
        {
            HealAmount = 30;
        }

        public void DoHeal(Unit unit)
        {
            unit.Health += HealAmount;
            
        }
    }
}
