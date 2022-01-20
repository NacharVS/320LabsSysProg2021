using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{

    class Archer : Unit
    {
        public int ArrowValue;


        public Archer(string name) : base(name, 300, 13, 1, 5, true , 50)
        {
            ArrowValue = 5;
        }

        public override void AttackUnit(Unit defender, double distance)
        {
            if(ArrowValue > 0)
            {
                if(distance < MaxRangeAttack)
                {
                    rangeAttack(defender);
                }
                
            }
            else
            {
                if(distance <= 1)
                {
                    defender.Health -= (new Random()).Next((int)(Damage * 0.8), (int)(Damage * 1.2));
                }
            }
            
        }

        void rangeAttack(Unit defender)
        {
            ArrowValue -= 1;
            defender.Health -= (new Random()).Next((int)(Damage * 0.8), (int)(Damage * 1.2)) * 1.5;
            if (ArrowValue == 0)
            {
                CanRangeAttack = false;
            }
        }

    }

}
