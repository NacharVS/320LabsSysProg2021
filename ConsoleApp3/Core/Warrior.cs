using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : Unit
    {
        private bool _rage = false;
        public Warrior(string name) : base(name, 200, 15, 1, 4 , false , 1)
        {
            
        }
        public override void AttackUnit(Unit defender, double distance)
        {
            if(Health > MaxHealth / 2)
            {
                defender.Health -= (new Random()).Next((int)(Damage * 0.8), (int)(Damage * 1.2));
            }
            else
            {
                if (!_rage)
                {
                    Console.WriteLine($"{Name} activate RAGE");
                    AttackSpeed /= 2;
                }
                _rage = true;
                defender.Health -= (new Random()).Next((int)(Damage * 2 * 0.8), (int)(Damage * 2 * 1.2));
            }
            
        }

    }
}
