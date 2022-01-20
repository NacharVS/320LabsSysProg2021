using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : Unit
    {
        private bool _rage = false;
        public Warrior(string name) : base(name, 200, 15, 1, 4, false, 1)
        {

        }

        public override void Hit(Unit defender, double distance)
        {
            if (Health > MaxHealth / 2)
            {
                defender.Health -= Damage;
            }
            else
            {
                if (!_rage)
                {
                    Console.WriteLine($"{Name} RAGE");
                    AttackSpeed /= 2;
                }
                _rage = true;
                defender.Health -= Damage;
            }

        }
    }
}
