using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : UnitBattle
    {
        public Warrior(string name) : base(name, 100, 3, 8, 5) { }

        public override double Infighting()
        {
            if (!rage && Health > 0.4 * _maxHealth)
            {
                return base.Infighting();

            }
            else
            {
                rage = true;
                return base.Infighting() * 2;
            }
        }
    }
}
