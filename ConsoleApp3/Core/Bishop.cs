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

        public Bishop(string name, double health, double heal) : base(name, health, 20, 30)
        {

            HealAmount = heal;
        }
        public void Heal(Unit unit)
        {
            if (unit.Health + HealAmount < unit.MaxHealth)
            {
                unit.Health += unit.MaxHealth;
            }
            else
            {
                Console.WriteLine("Health is max");
            }

        }
    }
}
