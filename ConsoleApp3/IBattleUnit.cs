using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    interface IBattleUnit
    {
        public void Attack(IBattleUnit u, double d);
        double damage { get; set; }
        double health { get; set; }
        string name { get; set; }

    }
}
