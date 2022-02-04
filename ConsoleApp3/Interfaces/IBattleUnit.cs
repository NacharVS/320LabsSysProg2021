using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Interfaces
{
    interface IBattleUnit : IUnit
    {
        double Damage { get; }
        double AttackSpeed { get; }

        void MeleeAttack(IUnit unit);
        void Attack(IUnit unit);
    }
}
