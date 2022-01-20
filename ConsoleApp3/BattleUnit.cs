using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class BattleUnit : Unit
    {
        public int minDamage;
        public int maxDamage;

        public BattleUnit(string name, int health, int armor, int speedParam, int min, int max) : base(name, health, armor)
        {
            minDamage = min;
            maxDamage = max;
        }

        public virtual double MleeAttack(Random rnd)
        {
            double currentDamage = Convert.ToDouble(rnd.Next(minDamage, maxDamage));
            return currentDamage;

        }
    }
}
