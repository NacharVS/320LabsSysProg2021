using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Interfaces
{
    internal interface IBattleUnit
    {
        int damage { get; }
        int AttackSpeed { get; }
        void Hit(Unit unit);
    }
}
