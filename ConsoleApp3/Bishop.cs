using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Bishop : Unit
    {
        public delegate void HealingChangedDelegate(string message);
        public double HealAmount { get; set; }

        public event HealingChangedDelegate HealingChandgedEvent;
        public Bishop()
        {
            HealAmount = 5;
        }

        public void Heal(Unit unit)
        {
            unit.Health += HealAmount;
            HealingChandgedEvent?.Invoke("Before Heal: " + (unit.Health - this.HealAmount) + "\n" + "Heal: +" + this.HealAmount + " hp" + "\n" + "Health: " + unit.Health);
        }
    }
}
