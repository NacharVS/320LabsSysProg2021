using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Archer : Unit
    {
        public int ArrowValue;
        public Archer(string name) : base(name, 300, 13, 1, 5, true, 50)
        {
            ArrowValue = 5;
        }

        public override void Hit(Unit defender, double distance)
        {
            if (ArrowValue > 0)
            {
                if (distance <= MaxRangeAttack)
                {
                    RangeAttack(defender);
                }
            }
            else
            {
                if (distance <= 1)
                {
                    defender.Health -= Damage;
                }
            }
        }

        void RangeAttack(Unit defender)
        {
            ArrowValue -= 1;
            defender.Health -= Damage;
            if (ArrowValue == 0)
            {
                CanRangeAttack = false;
            }
        }
    }
}
