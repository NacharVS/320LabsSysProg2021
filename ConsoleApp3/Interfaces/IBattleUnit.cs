using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public interface IBattleUnit : IUnit
    {
        double AttackSpeed { get; }
        double Damage { get; }

        void Attack(IUnit unit);
    }
}
