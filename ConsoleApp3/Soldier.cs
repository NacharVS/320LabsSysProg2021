using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Soldier : BattleUnit
    {
        private bool _rage = false;

        public Soldier(string name) : base(name, 90, 10, 5, 2, 8)
        {
        }

        public override double MleeAttack(Random rnd)
        {
            if (Health > 0.4 * _maxHealth && _rage == false)
            {
                return base.MleeAttack(rnd);
            }
            else
            {
                _rage = true;
                Console.WriteLine($"{Name} RAGE!");
                return base.MleeAttack(rnd) * 2;
            }
        }
    }
}