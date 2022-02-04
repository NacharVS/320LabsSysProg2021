using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class BattleUnit : MovingUnits
    {
        public int minDamage;
        public int maxDamage;
        public BattleUnit(string name, double health, int Attackspeed, double maxH, int min, int max) : base(name, health, Attackspeed, maxH)
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
