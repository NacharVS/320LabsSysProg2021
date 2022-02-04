using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    interface IBattleUnit
    {
        public int atack { get; }
        public void Damage(IUnit unit);
    }
}
