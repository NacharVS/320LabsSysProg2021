using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Archer : Unit
    {
        public delegate void HealthChangedDelegate(string nameUnit);
        public event HealthChangedDelegate HealthChandgedEvent;

        public int ArrowValue;
        public Archer(string name) : base(name, 300, 13, 100, 500, true, 50)
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

            HealthChandgedEvent?.Invoke("Before health : " + (defender.Health + this.Damage)
                    + "\n" + "Damage: -" + this.Damage + "\n" + "Health: " + defender.Health);
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
