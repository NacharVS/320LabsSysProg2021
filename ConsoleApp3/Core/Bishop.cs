using ConsoleApp3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Bishop : Unit,IMovementUnit
    {
        private double _healCount;
        public Bishop(string name, double healCount)
        {

            HealCount = healCount;
        }
        public double HealCount
        {
            get { return _healCount; }
            set { _healCount = value; }

        }
        public void Heal(IUnit unit)
        {
            if (unit.Health + HealCount < unit.MaxHealth)
            {
                unit.Health += unit.MaxHealth;
            }
            else
            {
                Console.WriteLine("Health is max");
            }

        }

        public void Messange()
        {
            throw new NotImplementedException();
        }

        public double WalkingSpeed => throw new NotImplementedException();

        public string Name { get => name; set => name = value; }
        public double Health { get => health; set => health = value; }
        public double MaxHealth { get => maxHealth; set => maxHealth = value; }

    }
}
