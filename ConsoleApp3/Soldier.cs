using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Soldier : BattleUnit
    {
        private bool _rage = false;

        public Soldier(string name, int health, int attackSpeed, int walkingSpeed) : base(name, health, attackSpeed, walkingSpeed, 2, 8)
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