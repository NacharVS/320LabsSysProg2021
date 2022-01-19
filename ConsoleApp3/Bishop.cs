using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Bishop : Unit
    {
        public double HealAmount { get; set; }

        public Bishop(string name) : base(name, 600, 2.3, 1, 3)
        {
            HealAmount = 100;
            
        }
        public void Heal(Unit pers)
        {
            if (pers.Health != 0)
            {
                if (pers.Health + HealAmount < pers.MaxHealth)
                {
                    pers.Health += HealAmount;
                }
                else
                {
                    pers.Health = pers.MaxHealth;
                }
            }
            else
            {
                Console.WriteLine("It is impossible to heal a dead hero");
            }
            
        }
    }
}
