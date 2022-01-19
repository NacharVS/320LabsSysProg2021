using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Bishop : Unit
    {
        public Bishop(string name, double healCount):base(name,100,10,1,2)
        {
            HealCount = healCount;
        }

        public double _healCount;

        public double HealCount
        {
            get { return _healCount; }
            set { _healCount = value; }
            
        }
        public void Heal(Unit unit)
        {
            if (unit.Health + HealCount >= unit.MaxHealth)
            {
                unit.Health = unit.MaxHealth;
            }
            else
            {
                unit.Health += HealCount;
            }
            
        }
    }
}
