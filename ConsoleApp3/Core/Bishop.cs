using ConsoleApp3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Bishop : Unit,IMovementUnit
    {
        private double _healCount;
        public Bishop(string name, double healCount, double health, double maxHealth)
        {
            Name = name;
            HealCount = healCount;
            Health = health;
            MaxHealth = maxHealth;
        }
        public double HealCount
        {
            get { return _healCount; }
            set { _healCount = value; }

        }
        public void Heal(IBattleUnit unit)
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

        public double WalkingSpeed => 3;

        public string Name { get => name; set => name = value; }
        public double Health { get => health; set => health = value < 0 ? 0 : value; }
        public double MaxHealth { get => maxHealth; set => maxHealth = value; }

    }
}
