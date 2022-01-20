using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Bishop : MovingUnits
    {

        private double _healAmount;
        public double HealAmount
        {
            get { return _healAmount; }
            set { _healAmount = value; }
        }

        public Bishop(string name, double health, double ha) : base(name, health,20,30)
        {
            
            HealAmount = ha;
        }
        public void HealUnit(Unit unit)
        {
            if(unit.Health+ HealAmount <unit.MaxHealth)
            {
                unit.Health += HealAmount;
            }
            else
            {
                Console.WriteLine("health is max");
            }
            
        }

        
    }
}
