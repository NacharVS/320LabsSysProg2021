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
        public Bishop(string name, double healCount):base(name,100,10,1,2)
        {
            HealAmount = healCount;
        }

    public void Heal(Unit unit)
        {
            if (unit.Health == 0)
            {
                HealingChandgedEvent?.Invoke("Can't healing, unit is dead");
            }
            else if (unit.Health > unit.MaxHealth)
            {
                unit.Health = unit.MaxHealth;
                HealingChandgedEvent?.Invoke("Max hp");
            }
            else
            {
                unit.Health += HealAmount;
                HealingChandgedEvent?.Invoke("Before Heal: " + (unit.Health - this.HealAmount) + "\n" + "Heal: +" + this.HealAmount + " hp" + "\n" + "Health: " + unit.Health);
            }
        }
    }
}
